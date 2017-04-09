using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStation
{
	public static class Analytics
	{
		private static Bus_Station_Context _context = new Bus_Station_Context();

		/// <summary>
		/// Prints the ticket with a specified number.
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static string PrintTicket(int number)
		{
			var ticket =
				_context.Tickets.Where(t => t.TicketNumber == number).FirstOrDefault();

			if (ticket == null)
				throw new ArgumentException($"Ticket with number {number} doesn't exists.", nameof(number));

			StringBuilder result = new StringBuilder();

			result.AppendFormat($"/t/t {ticket.TicketNumber} /n");
			result.AppendFormat($"Дата: {ticket.Passage.Date} /n");
			result.AppendFormat($"Рейс: {ticket.Passage.Schedule} /n");
			result.AppendFormat($"Номер места: {ticket.SeatNumber} /n");
			result.AppendFormat($"Пасспорт: {ticket.Passanger.Passport} /n");
			result.AppendFormat($"Цена: {ticket.Passage.Bus.Cost * _context.Routes.Where(r => r.RouteNumber == ticket.Passage.RouteNumber).Select(r => r.KM).FirstOrDefault()} рублей /n");

			return result.ToString();
		}

		/// <summary>
		/// Prints the waybill with a specified number.
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static string PrintWaybill(string number)
		{
			var waybill =
				_context.Waybills.Where(w => w.WaybillNumber == number).FirstOrDefault();

			if (waybill == null)
				throw new ArgumentException($"Ticket with number {number} doesn't exists.", nameof(number));

			StringBuilder result = new StringBuilder();

			result.AppendFormat($"/t/t {waybill.WaybillNumber} /n");
			result.AppendFormat($"Рейс: {waybill.Passage} /n");
			result.AppendFormat($"Водитель: {waybill.Driver.FullName} /n");
			result.AppendFormat($"Гос.Номер автомобиля: {waybill.Passage.Bus.Number} /n");
			result.AppendFormat("/t/t Пассажиры: /n");
			foreach (var ticket in waybill.Passage.Tickets)
				result.AppendFormat($"{ticket.TicketNumber} /t {ticket.Passanger.Passport} /t {ticket.Passanger.FullName}");

			return result.ToString();
		}

		/// <summary>
		/// Checks if avaible seats on specified passage.
		/// </summary>
		/// <param name="passage">Specified pessage</param>
		public static void Trigger(Passage passage)
		{
			Ticket newTicket = new Ticket();

			if (_context.Tickets.Where(t => t.Passage == passage).Count() < passage.Bus.SeatCount)
				_context.Tickets.Add(newTicket);
			else
				MessageBox.Show("No avaible seats on specified route", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/// <summary>
		/// Gets the next passage from current city to a specified city.
		/// </summary>
		/// <param name="cityTo"></param>
		/// <param name="currentCity"></param>
		/// <returns></returns>
		public static Passage GetNextPassage(City cityTo, City currentCity)
		{
			var passagesToSpecifiedCity = _context.Passages
				.Where(p => p.RouteNumber == _context.Routes.Where(r => r.City == cityTo && r.City1 == currentCity).FirstOrDefault().RouteNumber);

			TimeSpan lastPassageToday = passagesToSpecifiedCity.Where(p => p.Date == DateTime.Now.Date).Max(p => p.DepartureTime);

			if (DateTime.Now.TimeOfDay > lastPassageToday)
				return passagesToSpecifiedCity.Where(p => p.Date == DateTime.Now.AddDays(1).Date).Where(p => p.DepartureTime == passagesToSpecifiedCity.Min(ps => ps.DepartureTime)).FirstOrDefault();

			TimeSpan nextPassageDepartureTime = passagesToSpecifiedCity.Select(p => p.DepartureTime).Where(t => t > DateTime.Now.TimeOfDay).Min();
			return passagesToSpecifiedCity.Where(p => p.Date == DateTime.Now.Date).Where(p => p.DepartureTime == nextPassageDepartureTime).FirstOrDefault();
		}

		/// <summary>
		/// Gets the most popular route for a specified year.
		/// </summary>
		/// <param name="year"></param>
		/// <param name="count"></param>
		/// <returns></returns>
		public static IQueryable GetMostPopularRoutesForYear(int year, int count)
		{
			return _context.Tickets
				.Where(t => t.Passage.Date.Year == year)
				.GroupBy(t => t.Passage.RouteNumber)
				.OrderByDescending(q => q.Count()).Take(count)
				.Select(t => new {RouteNumber = t.Key, SoldTicketsCount = t.Count()});
		}

		/// <summary>
		/// Gets the most pupular route for a specified month.
		/// </summary>
		/// <param name="month"></param>
		/// <param name="count"></param>
		/// <returns></returns>
		public static IQueryable GetMostPopularRoutesForMonth(int month, int count)
		{
			return _context.Tickets
				.Where(t => t.Passage.Date.Month == month)
				.GroupBy(t => t.Passage.RouteNumber)
				.OrderByDescending(q => q.Count()).Take(count)
				.Select(t => new { RouteNumber = t.Key, SoldTicketsCount = t.Count() });
		}

		/// <summary>
		/// Gets routes, schedule of which can be revised.
		/// </summary>
		/// <param name="month">Year to inspect</param>
		/// <param name="allowablePercent"></param>
		/// <returns></returns>
		public static IQueryable GetRoutesToReduceMonthly(int month, double allowablePercent)
		{
			// сокращение кол-ва рейсов: считаем средний процент за определенный срок( например, неделю), если он меньше необходимого (например, 50%), тогда выдаем маршрут, по которому можно урезать.
			var query = _context.Passages
				.Where(p => p.Date.Month == month)
				.GroupBy(p => p.RouteNumber, s => new { soldTicketPercent = s.Tickets.Count / (double)s.Bus.SeatCount });

			query.Select(k => k.Where(q => q.soldTicketPercent < allowablePercent));

			return query.Select(q => q.Key);
		}

		/// <summary>
		/// Gets routes, schedule of which can be revised.
		/// </summary>
		/// <param name="year">Year to inspect</param>
		/// <param name="allowablePercent"></param>
		/// <returns></returns>
		public static IQueryable GetRoutesToReduceYearStat(int year, double allowablePercent)
		{
			var query = _context.Passages
				.Where(p => p.Date.Year == year)
				.GroupBy(p => p.RouteNumber, s => new { soldTicketPercent = s.Tickets.Count / (double)s.Bus.SeatCount });

			query.Select(k => k.Where(q => q.soldTicketPercent < allowablePercent));

			return query.Select(q => q.Key);
		}

		/// <summary>
		/// Gets the best selling routes for a specified month.
		/// </summary>
		/// <param name="count">Count of routes</param>
		/// <param name="month"></param>
		/// <returns></returns>
		public static IQueryable GetBestSellingRoutesMonth(int count, int month)
		{
			// самый продаваемый маршрут - количество билетов/количество мест
			var query = _context.Passages
				.Where(p => p.Date.Month == month)
				.GroupBy(p => p.RouteNumber, s => new { soldTicketPercent = s.Tickets.Count / (double)s.Bus.SeatCount });

			query.OrderByDescending(q => q.Average(k => k.soldTicketPercent));

			return query.Select(q => q.Key).Take(count);
		}
	}
}