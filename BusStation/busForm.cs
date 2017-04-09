using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStation
{
    public partial class BusForm : Form
    {
        private DataGridView busesDataGridView;
        private Button addBusButton;
        private Button deleteBusButton;
        private Button editBusButton;
        private TabPage busTabPage;
        private TabPage cityTabPage;
        private TabControl MainTabControl;
        private Button addCityButton;
        private Button editCityButton;
        private Button deleteCityButton;
        private DataGridView cityDataGridView;
        private TabPage driverTabPage;
        private Button driverAddButton;
        private Button driverEditButton;
        private Button driverDeleteButton;
        private DataGridView driverDataGridView;
        private TabPage passangerTabPage;
        private DataGridView passangerDataGridView;
        private Button passangerAddButton;
        private Button passangerEditButton;
        private Button passangerDeleteButton;
        private TabPage routeTabPage;
        private DataGridView routeDataGridView;
        private Button addRouteButton;
        private Button editRouteButton;
        private Button deleteRouteButton;
        private TabPage scheduleTabPage;
        private DataGridView scheduleDataGridView;
        private Button scheduleAddButton;
        private Button scheduleEditButton;
        private Button scheduleDeleteButton;
        private TabPage pasageTabPage;
        private DataGridView passagesDataGridView;
        private Button addPassageButton;
        private Button editPassageButton;
        private Button deletePassageutton;
		private TabPage ticketTabPage;
		private DataGridView ticketsDataGridView;
		private Button AddTicketButton;
		private Button button2;
		private Button RemoveTicketButton;
		private TabPage waybillTabPage;
		private DataGridView waybillDataGridView;
		private Button addWaybillButton;
		private Button button3;
		private Button button4;
		private Bus_Station_Context _context;

        public BusForm()
        {
            InitializeComponent();

            _context = new Bus_Station_Context();

            _context.Buses.Load();
            busesDataGridView.DataSource = _context.Buses.Local.ToBindingList();
			busesDataGridView.Columns["Passages"].Visible = false;

			_context.Cities.Load();
            cityDataGridView.DataSource = _context.Cities.Local.ToBindingList();
			cityDataGridView.Columns["Routes"].Visible = false;
			cityDataGridView.Columns["Routes1"].Visible = false;

			_context.Drivers.Load();
            driverDataGridView.DataSource = _context.Drivers.Local.ToBindingList();
			driverDataGridView.Columns["Waybills"].Visible = false;

			_context.Passangers.Load();
            passangerDataGridView.DataSource = _context.Passangers.Local.ToBindingList();
			passangerDataGridView.Columns["Tickets"].Visible = false;

			_context.Routes.Load();
            routeDataGridView.DataSource = _context.Routes.Local.ToBindingList();
			routeDataGridView.Columns["Schedules"].Visible = false;

			_context.Schedules.Load();
            scheduleDataGridView.DataSource = _context.Schedules.Local.ToBindingList();
			scheduleDataGridView.Columns["RouteNumber"].Visible = false;
			scheduleDataGridView.Columns["Passages"].Visible = false;

			_context.Passages.Load();
            passagesDataGridView.DataSource = _context.Passages.Local.ToBindingList();
			passagesDataGridView.Columns["RouteNumber"].Visible = false;
			passagesDataGridView.Columns["DepartureTime"].Visible = false;
			passagesDataGridView.Columns["Tickets"].Visible = false;
			passagesDataGridView.Columns["Waybills"].Visible = false;

			_context.Tickets.Load();
			ticketsDataGridView.DataSource = _context.Tickets.Local.ToBindingList();

			_context.Waybills.Load();
			waybillDataGridView.DataSource = _context.Waybills.Local.ToBindingList();
			waybillDataGridView.Columns["Passage"].Visible = false;
			waybillDataGridView.Columns["Driver"].Visible = false;
        }

        private void InitializeComponent()
        {
			this.busesDataGridView = new System.Windows.Forms.DataGridView();
			this.addBusButton = new System.Windows.Forms.Button();
			this.deleteBusButton = new System.Windows.Forms.Button();
			this.editBusButton = new System.Windows.Forms.Button();
			this.MainTabControl = new System.Windows.Forms.TabControl();
			this.busTabPage = new System.Windows.Forms.TabPage();
			this.cityTabPage = new System.Windows.Forms.TabPage();
			this.addCityButton = new System.Windows.Forms.Button();
			this.editCityButton = new System.Windows.Forms.Button();
			this.deleteCityButton = new System.Windows.Forms.Button();
			this.cityDataGridView = new System.Windows.Forms.DataGridView();
			this.driverTabPage = new System.Windows.Forms.TabPage();
			this.driverAddButton = new System.Windows.Forms.Button();
			this.driverEditButton = new System.Windows.Forms.Button();
			this.driverDeleteButton = new System.Windows.Forms.Button();
			this.driverDataGridView = new System.Windows.Forms.DataGridView();
			this.passangerTabPage = new System.Windows.Forms.TabPage();
			this.passangerDataGridView = new System.Windows.Forms.DataGridView();
			this.passangerAddButton = new System.Windows.Forms.Button();
			this.passangerEditButton = new System.Windows.Forms.Button();
			this.passangerDeleteButton = new System.Windows.Forms.Button();
			this.routeTabPage = new System.Windows.Forms.TabPage();
			this.routeDataGridView = new System.Windows.Forms.DataGridView();
			this.addRouteButton = new System.Windows.Forms.Button();
			this.editRouteButton = new System.Windows.Forms.Button();
			this.deleteRouteButton = new System.Windows.Forms.Button();
			this.scheduleTabPage = new System.Windows.Forms.TabPage();
			this.scheduleDataGridView = new System.Windows.Forms.DataGridView();
			this.scheduleAddButton = new System.Windows.Forms.Button();
			this.scheduleEditButton = new System.Windows.Forms.Button();
			this.scheduleDeleteButton = new System.Windows.Forms.Button();
			this.pasageTabPage = new System.Windows.Forms.TabPage();
			this.passagesDataGridView = new System.Windows.Forms.DataGridView();
			this.addPassageButton = new System.Windows.Forms.Button();
			this.editPassageButton = new System.Windows.Forms.Button();
			this.deletePassageutton = new System.Windows.Forms.Button();
			this.ticketTabPage = new System.Windows.Forms.TabPage();
			this.ticketsDataGridView = new System.Windows.Forms.DataGridView();
			this.AddTicketButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.RemoveTicketButton = new System.Windows.Forms.Button();
			this.waybillTabPage = new System.Windows.Forms.TabPage();
			this.waybillDataGridView = new System.Windows.Forms.DataGridView();
			this.addWaybillButton = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.busesDataGridView)).BeginInit();
			this.MainTabControl.SuspendLayout();
			this.busTabPage.SuspendLayout();
			this.cityTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).BeginInit();
			this.driverTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.driverDataGridView)).BeginInit();
			this.passangerTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.passangerDataGridView)).BeginInit();
			this.routeTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.routeDataGridView)).BeginInit();
			this.scheduleTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).BeginInit();
			this.pasageTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.passagesDataGridView)).BeginInit();
			this.ticketTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).BeginInit();
			this.waybillTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.waybillDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// busesDataGridView
			// 
			this.busesDataGridView.AllowUserToAddRows = false;
			this.busesDataGridView.AllowUserToDeleteRows = false;
			this.busesDataGridView.AllowUserToResizeRows = false;
			this.busesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.busesDataGridView.Location = new System.Drawing.Point(94, 29);
			this.busesDataGridView.MultiSelect = false;
			this.busesDataGridView.Name = "busesDataGridView";
			this.busesDataGridView.ReadOnly = true;
			this.busesDataGridView.RowTemplate.Height = 24;
			this.busesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.busesDataGridView.Size = new System.Drawing.Size(577, 345);
			this.busesDataGridView.TabIndex = 0;
			// 
			// addBusButton
			// 
			this.addBusButton.Location = new System.Drawing.Point(94, 405);
			this.addBusButton.Name = "addBusButton";
			this.addBusButton.Size = new System.Drawing.Size(111, 31);
			this.addBusButton.TabIndex = 1;
			this.addBusButton.Text = "Добавить";
			this.addBusButton.UseVisualStyleBackColor = true;
			this.addBusButton.Click += new System.EventHandler(this.AddBusButton_Click);
			// 
			// deleteBusButton
			// 
			this.deleteBusButton.Location = new System.Drawing.Point(560, 405);
			this.deleteBusButton.Name = "deleteBusButton";
			this.deleteBusButton.Size = new System.Drawing.Size(111, 31);
			this.deleteBusButton.TabIndex = 2;
			this.deleteBusButton.Text = "Удалить";
			this.deleteBusButton.UseVisualStyleBackColor = true;
			this.deleteBusButton.Click += new System.EventHandler(this.DeleteBusButton_Click);
			// 
			// editBusButton
			// 
			this.editBusButton.Location = new System.Drawing.Point(324, 405);
			this.editBusButton.Name = "editBusButton";
			this.editBusButton.Size = new System.Drawing.Size(125, 31);
			this.editBusButton.TabIndex = 3;
			this.editBusButton.Text = "Редактировать";
			this.editBusButton.UseVisualStyleBackColor = true;
			this.editBusButton.Click += new System.EventHandler(this.EditBusButton_Click);
			// 
			// MainTabControl
			// 
			this.MainTabControl.Controls.Add(this.busTabPage);
			this.MainTabControl.Controls.Add(this.cityTabPage);
			this.MainTabControl.Controls.Add(this.driverTabPage);
			this.MainTabControl.Controls.Add(this.passangerTabPage);
			this.MainTabControl.Controls.Add(this.routeTabPage);
			this.MainTabControl.Controls.Add(this.scheduleTabPage);
			this.MainTabControl.Controls.Add(this.pasageTabPage);
			this.MainTabControl.Controls.Add(this.ticketTabPage);
			this.MainTabControl.Controls.Add(this.waybillTabPage);
			this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainTabControl.Location = new System.Drawing.Point(0, 0);
			this.MainTabControl.Name = "MainTabControl";
			this.MainTabControl.SelectedIndex = 0;
			this.MainTabControl.Size = new System.Drawing.Size(744, 497);
			this.MainTabControl.TabIndex = 4;
			// 
			// busTabPage
			// 
			this.busTabPage.Controls.Add(this.busesDataGridView);
			this.busTabPage.Controls.Add(this.addBusButton);
			this.busTabPage.Controls.Add(this.editBusButton);
			this.busTabPage.Controls.Add(this.deleteBusButton);
			this.busTabPage.Location = new System.Drawing.Point(4, 22);
			this.busTabPage.Name = "busTabPage";
			this.busTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.busTabPage.Size = new System.Drawing.Size(736, 471);
			this.busTabPage.TabIndex = 0;
			this.busTabPage.Text = "Автобусы";
			this.busTabPage.UseVisualStyleBackColor = true;
			// 
			// cityTabPage
			// 
			this.cityTabPage.Controls.Add(this.addCityButton);
			this.cityTabPage.Controls.Add(this.editCityButton);
			this.cityTabPage.Controls.Add(this.deleteCityButton);
			this.cityTabPage.Controls.Add(this.cityDataGridView);
			this.cityTabPage.Location = new System.Drawing.Point(4, 22);
			this.cityTabPage.Name = "cityTabPage";
			this.cityTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.cityTabPage.Size = new System.Drawing.Size(736, 471);
			this.cityTabPage.TabIndex = 1;
			this.cityTabPage.Text = "Города";
			this.cityTabPage.UseVisualStyleBackColor = true;
			// 
			// addCityButton
			// 
			this.addCityButton.Location = new System.Drawing.Point(71, 409);
			this.addCityButton.Name = "addCityButton";
			this.addCityButton.Size = new System.Drawing.Size(111, 31);
			this.addCityButton.TabIndex = 4;
			this.addCityButton.Text = "Добавить";
			this.addCityButton.UseVisualStyleBackColor = true;
			this.addCityButton.Click += new System.EventHandler(this.AddCityButton_Click);
			// 
			// editCityButton
			// 
			this.editCityButton.Location = new System.Drawing.Point(296, 409);
			this.editCityButton.Name = "editCityButton";
			this.editCityButton.Size = new System.Drawing.Size(125, 31);
			this.editCityButton.TabIndex = 6;
			this.editCityButton.Text = "Редактировать";
			this.editCityButton.UseVisualStyleBackColor = true;
			this.editCityButton.Click += new System.EventHandler(this.EditCityButton_Click);
			// 
			// deleteCityButton
			// 
			this.deleteCityButton.Location = new System.Drawing.Point(550, 409);
			this.deleteCityButton.Name = "deleteCityButton";
			this.deleteCityButton.Size = new System.Drawing.Size(111, 31);
			this.deleteCityButton.TabIndex = 5;
			this.deleteCityButton.Text = "Удалить";
			this.deleteCityButton.UseVisualStyleBackColor = true;
			this.deleteCityButton.Click += new System.EventHandler(this.DeleteCityButton_Click);
			// 
			// cityDataGridView
			// 
			this.cityDataGridView.AllowUserToAddRows = false;
			this.cityDataGridView.AllowUserToDeleteRows = false;
			this.cityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cityDataGridView.Location = new System.Drawing.Point(173, 25);
			this.cityDataGridView.MultiSelect = false;
			this.cityDataGridView.Name = "cityDataGridView";
			this.cityDataGridView.ReadOnly = true;
			this.cityDataGridView.RowTemplate.Height = 24;
			this.cityDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.cityDataGridView.Size = new System.Drawing.Size(371, 358);
			this.cityDataGridView.TabIndex = 0;
			// 
			// driverTabPage
			// 
			this.driverTabPage.Controls.Add(this.driverAddButton);
			this.driverTabPage.Controls.Add(this.driverEditButton);
			this.driverTabPage.Controls.Add(this.driverDeleteButton);
			this.driverTabPage.Controls.Add(this.driverDataGridView);
			this.driverTabPage.Location = new System.Drawing.Point(4, 22);
			this.driverTabPage.Name = "driverTabPage";
			this.driverTabPage.Size = new System.Drawing.Size(736, 471);
			this.driverTabPage.TabIndex = 2;
			this.driverTabPage.Text = "Водители";
			this.driverTabPage.UseVisualStyleBackColor = true;
			// 
			// driverAddButton
			// 
			this.driverAddButton.Location = new System.Drawing.Point(73, 411);
			this.driverAddButton.Name = "driverAddButton";
			this.driverAddButton.Size = new System.Drawing.Size(106, 31);
			this.driverAddButton.TabIndex = 8;
			this.driverAddButton.Text = "Добавить";
			this.driverAddButton.UseVisualStyleBackColor = true;
			this.driverAddButton.Click += new System.EventHandler(this.DriverAddButton_Click);
			// 
			// driverEditButton
			// 
			this.driverEditButton.Location = new System.Drawing.Point(298, 411);
			this.driverEditButton.Name = "driverEditButton";
			this.driverEditButton.Size = new System.Drawing.Size(120, 31);
			this.driverEditButton.TabIndex = 10;
			this.driverEditButton.Text = "Редактировать";
			this.driverEditButton.UseVisualStyleBackColor = true;
			this.driverEditButton.Click += new System.EventHandler(this.DriverEditButton_Click);
			// 
			// driverDeleteButton
			// 
			this.driverDeleteButton.Location = new System.Drawing.Point(552, 411);
			this.driverDeleteButton.Name = "driverDeleteButton";
			this.driverDeleteButton.Size = new System.Drawing.Size(106, 31);
			this.driverDeleteButton.TabIndex = 9;
			this.driverDeleteButton.Text = "Удалить";
			this.driverDeleteButton.UseVisualStyleBackColor = true;
			this.driverDeleteButton.Click += new System.EventHandler(this.DriverDeleteButton_Click);
			// 
			// driverDataGridView
			// 
			this.driverDataGridView.AllowUserToAddRows = false;
			this.driverDataGridView.AllowUserToDeleteRows = false;
			this.driverDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.driverDataGridView.Location = new System.Drawing.Point(73, 26);
			this.driverDataGridView.MultiSelect = false;
			this.driverDataGridView.Name = "driverDataGridView";
			this.driverDataGridView.ReadOnly = true;
			this.driverDataGridView.RowTemplate.Height = 24;
			this.driverDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.driverDataGridView.Size = new System.Drawing.Size(585, 358);
			this.driverDataGridView.TabIndex = 7;
			// 
			// passangerTabPage
			// 
			this.passangerTabPage.Controls.Add(this.passangerDataGridView);
			this.passangerTabPage.Controls.Add(this.passangerAddButton);
			this.passangerTabPage.Controls.Add(this.passangerEditButton);
			this.passangerTabPage.Controls.Add(this.passangerDeleteButton);
			this.passangerTabPage.Location = new System.Drawing.Point(4, 22);
			this.passangerTabPage.Name = "passangerTabPage";
			this.passangerTabPage.Size = new System.Drawing.Size(736, 471);
			this.passangerTabPage.TabIndex = 3;
			this.passangerTabPage.Text = "Пассажиры";
			this.passangerTabPage.UseVisualStyleBackColor = true;
			// 
			// passangerDataGridView
			// 
			this.passangerDataGridView.AllowUserToAddRows = false;
			this.passangerDataGridView.AllowUserToDeleteRows = false;
			this.passangerDataGridView.AllowUserToResizeRows = false;
			this.passangerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.passangerDataGridView.Location = new System.Drawing.Point(80, 31);
			this.passangerDataGridView.MultiSelect = false;
			this.passangerDataGridView.Name = "passangerDataGridView";
			this.passangerDataGridView.ReadOnly = true;
			this.passangerDataGridView.RowTemplate.Height = 24;
			this.passangerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.passangerDataGridView.Size = new System.Drawing.Size(577, 345);
			this.passangerDataGridView.TabIndex = 4;
			// 
			// passangerAddButton
			// 
			this.passangerAddButton.Location = new System.Drawing.Point(80, 407);
			this.passangerAddButton.Name = "passangerAddButton";
			this.passangerAddButton.Size = new System.Drawing.Size(111, 31);
			this.passangerAddButton.TabIndex = 5;
			this.passangerAddButton.Text = "Добавить";
			this.passangerAddButton.UseVisualStyleBackColor = true;
			this.passangerAddButton.Click += new System.EventHandler(this.PassangerAddButton_Click);
			// 
			// passangerEditButton
			// 
			this.passangerEditButton.Location = new System.Drawing.Point(310, 407);
			this.passangerEditButton.Name = "passangerEditButton";
			this.passangerEditButton.Size = new System.Drawing.Size(125, 31);
			this.passangerEditButton.TabIndex = 7;
			this.passangerEditButton.Text = "Редактировать";
			this.passangerEditButton.UseVisualStyleBackColor = true;
			this.passangerEditButton.Click += new System.EventHandler(this.PassangerEditButton_Click);
			// 
			// passangerDeleteButton
			// 
			this.passangerDeleteButton.Location = new System.Drawing.Point(546, 407);
			this.passangerDeleteButton.Name = "passangerDeleteButton";
			this.passangerDeleteButton.Size = new System.Drawing.Size(111, 31);
			this.passangerDeleteButton.TabIndex = 6;
			this.passangerDeleteButton.Text = "Удалить";
			this.passangerDeleteButton.UseVisualStyleBackColor = true;
			this.passangerDeleteButton.Click += new System.EventHandler(this.PassangerDeleteButton_Click);
			// 
			// routeTabPage
			// 
			this.routeTabPage.Controls.Add(this.routeDataGridView);
			this.routeTabPage.Controls.Add(this.addRouteButton);
			this.routeTabPage.Controls.Add(this.editRouteButton);
			this.routeTabPage.Controls.Add(this.deleteRouteButton);
			this.routeTabPage.Location = new System.Drawing.Point(4, 22);
			this.routeTabPage.Name = "routeTabPage";
			this.routeTabPage.Size = new System.Drawing.Size(736, 471);
			this.routeTabPage.TabIndex = 4;
			this.routeTabPage.Text = "Маршруты";
			this.routeTabPage.UseVisualStyleBackColor = true;
			// 
			// routeDataGridView
			// 
			this.routeDataGridView.AllowUserToAddRows = false;
			this.routeDataGridView.AllowUserToDeleteRows = false;
			this.routeDataGridView.AllowUserToResizeRows = false;
			this.routeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.routeDataGridView.Location = new System.Drawing.Point(80, 31);
			this.routeDataGridView.MultiSelect = false;
			this.routeDataGridView.Name = "routeDataGridView";
			this.routeDataGridView.ReadOnly = true;
			this.routeDataGridView.RowTemplate.Height = 24;
			this.routeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.routeDataGridView.Size = new System.Drawing.Size(577, 345);
			this.routeDataGridView.TabIndex = 4;
			// 
			// addRouteButton
			// 
			this.addRouteButton.Location = new System.Drawing.Point(80, 407);
			this.addRouteButton.Name = "addRouteButton";
			this.addRouteButton.Size = new System.Drawing.Size(111, 31);
			this.addRouteButton.TabIndex = 5;
			this.addRouteButton.Text = "Добавить";
			this.addRouteButton.UseVisualStyleBackColor = true;
			this.addRouteButton.Click += new System.EventHandler(this.AddRouteButton_Click);
			// 
			// editRouteButton
			// 
			this.editRouteButton.Location = new System.Drawing.Point(310, 407);
			this.editRouteButton.Name = "editRouteButton";
			this.editRouteButton.Size = new System.Drawing.Size(125, 31);
			this.editRouteButton.TabIndex = 7;
			this.editRouteButton.Text = "Редактировать";
			this.editRouteButton.UseVisualStyleBackColor = true;
			this.editRouteButton.Click += new System.EventHandler(this.EditRouteButton_Click);
			// 
			// deleteRouteButton
			// 
			this.deleteRouteButton.Location = new System.Drawing.Point(546, 407);
			this.deleteRouteButton.Name = "deleteRouteButton";
			this.deleteRouteButton.Size = new System.Drawing.Size(111, 31);
			this.deleteRouteButton.TabIndex = 6;
			this.deleteRouteButton.Text = "Удалить";
			this.deleteRouteButton.UseVisualStyleBackColor = true;
			this.deleteRouteButton.Click += new System.EventHandler(this.DeleteRouteButton_Click);
			// 
			// scheduleTabPage
			// 
			this.scheduleTabPage.Controls.Add(this.scheduleDataGridView);
			this.scheduleTabPage.Controls.Add(this.scheduleAddButton);
			this.scheduleTabPage.Controls.Add(this.scheduleEditButton);
			this.scheduleTabPage.Controls.Add(this.scheduleDeleteButton);
			this.scheduleTabPage.Location = new System.Drawing.Point(4, 22);
			this.scheduleTabPage.Name = "scheduleTabPage";
			this.scheduleTabPage.Size = new System.Drawing.Size(736, 471);
			this.scheduleTabPage.TabIndex = 5;
			this.scheduleTabPage.Text = "Расписание";
			this.scheduleTabPage.UseVisualStyleBackColor = true;
			// 
			// scheduleDataGridView
			// 
			this.scheduleDataGridView.AllowUserToAddRows = false;
			this.scheduleDataGridView.AllowUserToDeleteRows = false;
			this.scheduleDataGridView.AllowUserToResizeRows = false;
			this.scheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.scheduleDataGridView.Location = new System.Drawing.Point(80, 40);
			this.scheduleDataGridView.MultiSelect = false;
			this.scheduleDataGridView.Name = "scheduleDataGridView";
			this.scheduleDataGridView.ReadOnly = true;
			this.scheduleDataGridView.RowTemplate.Height = 24;
			this.scheduleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.scheduleDataGridView.Size = new System.Drawing.Size(577, 345);
			this.scheduleDataGridView.TabIndex = 4;
			// 
			// scheduleAddButton
			// 
			this.scheduleAddButton.Location = new System.Drawing.Point(80, 407);
			this.scheduleAddButton.Name = "scheduleAddButton";
			this.scheduleAddButton.Size = new System.Drawing.Size(111, 31);
			this.scheduleAddButton.TabIndex = 5;
			this.scheduleAddButton.Text = "Добавить";
			this.scheduleAddButton.UseVisualStyleBackColor = true;
			this.scheduleAddButton.Click += new System.EventHandler(this.ScheduleAddButton_Click);
			// 
			// scheduleEditButton
			// 
			this.scheduleEditButton.Location = new System.Drawing.Point(310, 407);
			this.scheduleEditButton.Name = "scheduleEditButton";
			this.scheduleEditButton.Size = new System.Drawing.Size(125, 31);
			this.scheduleEditButton.TabIndex = 7;
			this.scheduleEditButton.Text = "Редактировать";
			this.scheduleEditButton.UseVisualStyleBackColor = true;
			this.scheduleEditButton.Visible = false;
			this.scheduleEditButton.Click += new System.EventHandler(this.ScheduleEditButton_Click);
			// 
			// scheduleDeleteButton
			// 
			this.scheduleDeleteButton.Location = new System.Drawing.Point(546, 407);
			this.scheduleDeleteButton.Name = "scheduleDeleteButton";
			this.scheduleDeleteButton.Size = new System.Drawing.Size(111, 31);
			this.scheduleDeleteButton.TabIndex = 6;
			this.scheduleDeleteButton.Text = "Удалить";
			this.scheduleDeleteButton.UseVisualStyleBackColor = true;
			this.scheduleDeleteButton.Click += new System.EventHandler(this.ScheduleDeleteButton_Click);
			// 
			// pasageTabPage
			// 
			this.pasageTabPage.Controls.Add(this.passagesDataGridView);
			this.pasageTabPage.Controls.Add(this.addPassageButton);
			this.pasageTabPage.Controls.Add(this.editPassageButton);
			this.pasageTabPage.Controls.Add(this.deletePassageutton);
			this.pasageTabPage.Location = new System.Drawing.Point(4, 22);
			this.pasageTabPage.Name = "pasageTabPage";
			this.pasageTabPage.Size = new System.Drawing.Size(736, 471);
			this.pasageTabPage.TabIndex = 6;
			this.pasageTabPage.Text = "Рейсы";
			this.pasageTabPage.UseVisualStyleBackColor = true;
			// 
			// passagesDataGridView
			// 
			this.passagesDataGridView.AllowUserToAddRows = false;
			this.passagesDataGridView.AllowUserToDeleteRows = false;
			this.passagesDataGridView.AllowUserToResizeRows = false;
			this.passagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.passagesDataGridView.Location = new System.Drawing.Point(80, 31);
			this.passagesDataGridView.MultiSelect = false;
			this.passagesDataGridView.Name = "passagesDataGridView";
			this.passagesDataGridView.ReadOnly = true;
			this.passagesDataGridView.RowTemplate.Height = 24;
			this.passagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.passagesDataGridView.Size = new System.Drawing.Size(577, 345);
			this.passagesDataGridView.TabIndex = 4;
			// 
			// addPassageButton
			// 
			this.addPassageButton.Location = new System.Drawing.Point(80, 407);
			this.addPassageButton.Name = "addPassageButton";
			this.addPassageButton.Size = new System.Drawing.Size(111, 31);
			this.addPassageButton.TabIndex = 5;
			this.addPassageButton.Text = "Добавить";
			this.addPassageButton.UseVisualStyleBackColor = true;
			this.addPassageButton.Click += new System.EventHandler(this.AddPassageButton_Click);
			// 
			// editPassageButton
			// 
			this.editPassageButton.Location = new System.Drawing.Point(310, 407);
			this.editPassageButton.Name = "editPassageButton";
			this.editPassageButton.Size = new System.Drawing.Size(125, 31);
			this.editPassageButton.TabIndex = 7;
			this.editPassageButton.Text = "Редактировать";
			this.editPassageButton.UseVisualStyleBackColor = true;
			this.editPassageButton.Visible = false;
			this.editPassageButton.Click += new System.EventHandler(this.EditPassageButton_Click);
			// 
			// deletePassageutton
			// 
			this.deletePassageutton.Location = new System.Drawing.Point(546, 407);
			this.deletePassageutton.Name = "deletePassageutton";
			this.deletePassageutton.Size = new System.Drawing.Size(111, 31);
			this.deletePassageutton.TabIndex = 6;
			this.deletePassageutton.Text = "Удалить";
			this.deletePassageutton.UseVisualStyleBackColor = true;
			// 
			// ticketTabPage
			// 
			this.ticketTabPage.Controls.Add(this.ticketsDataGridView);
			this.ticketTabPage.Controls.Add(this.AddTicketButton);
			this.ticketTabPage.Controls.Add(this.button2);
			this.ticketTabPage.Controls.Add(this.RemoveTicketButton);
			this.ticketTabPage.Location = new System.Drawing.Point(4, 22);
			this.ticketTabPage.Name = "ticketTabPage";
			this.ticketTabPage.Size = new System.Drawing.Size(736, 471);
			this.ticketTabPage.TabIndex = 7;
			this.ticketTabPage.Text = "Билеты";
			this.ticketTabPage.UseVisualStyleBackColor = true;
			// 
			// ticketsDataGridView
			// 
			this.ticketsDataGridView.AllowUserToAddRows = false;
			this.ticketsDataGridView.AllowUserToDeleteRows = false;
			this.ticketsDataGridView.AllowUserToResizeRows = false;
			this.ticketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ticketsDataGridView.Location = new System.Drawing.Point(80, 32);
			this.ticketsDataGridView.MultiSelect = false;
			this.ticketsDataGridView.Name = "ticketsDataGridView";
			this.ticketsDataGridView.ReadOnly = true;
			this.ticketsDataGridView.RowTemplate.Height = 24;
			this.ticketsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ticketsDataGridView.Size = new System.Drawing.Size(577, 345);
			this.ticketsDataGridView.TabIndex = 8;
			// 
			// AddTicketButton
			// 
			this.AddTicketButton.Location = new System.Drawing.Point(80, 408);
			this.AddTicketButton.Name = "AddTicketButton";
			this.AddTicketButton.Size = new System.Drawing.Size(111, 31);
			this.AddTicketButton.TabIndex = 9;
			this.AddTicketButton.Text = "Добавить";
			this.AddTicketButton.UseVisualStyleBackColor = true;
			this.AddTicketButton.Click += new System.EventHandler(this.AddTicketButton_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(310, 408);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(125, 31);
			this.button2.TabIndex = 11;
			this.button2.Text = "Редактировать";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			// 
			// RemoveTicketButton
			// 
			this.RemoveTicketButton.Location = new System.Drawing.Point(546, 408);
			this.RemoveTicketButton.Name = "RemoveTicketButton";
			this.RemoveTicketButton.Size = new System.Drawing.Size(111, 31);
			this.RemoveTicketButton.TabIndex = 10;
			this.RemoveTicketButton.Text = "Удалить";
			this.RemoveTicketButton.UseVisualStyleBackColor = true;
			this.RemoveTicketButton.Click += new System.EventHandler(this.RemoveTicketButton_Click);
			// 
			// waybillTabPage
			// 
			this.waybillTabPage.Controls.Add(this.waybillDataGridView);
			this.waybillTabPage.Controls.Add(this.addWaybillButton);
			this.waybillTabPage.Controls.Add(this.button3);
			this.waybillTabPage.Controls.Add(this.button4);
			this.waybillTabPage.Location = new System.Drawing.Point(4, 22);
			this.waybillTabPage.Name = "waybillTabPage";
			this.waybillTabPage.Size = new System.Drawing.Size(736, 471);
			this.waybillTabPage.TabIndex = 8;
			this.waybillTabPage.Text = "Путевые листы";
			this.waybillTabPage.UseVisualStyleBackColor = true;
			// 
			// waybillDataGridView
			// 
			this.waybillDataGridView.AllowUserToAddRows = false;
			this.waybillDataGridView.AllowUserToDeleteRows = false;
			this.waybillDataGridView.AllowUserToResizeRows = false;
			this.waybillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.waybillDataGridView.Location = new System.Drawing.Point(80, 32);
			this.waybillDataGridView.MultiSelect = false;
			this.waybillDataGridView.Name = "waybillDataGridView";
			this.waybillDataGridView.ReadOnly = true;
			this.waybillDataGridView.RowTemplate.Height = 24;
			this.waybillDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.waybillDataGridView.Size = new System.Drawing.Size(577, 345);
			this.waybillDataGridView.TabIndex = 12;
			// 
			// addWaybillButton
			// 
			this.addWaybillButton.Location = new System.Drawing.Point(306, 408);
			this.addWaybillButton.Name = "addWaybillButton";
			this.addWaybillButton.Size = new System.Drawing.Size(111, 31);
			this.addWaybillButton.TabIndex = 13;
			this.addWaybillButton.Text = "Добавить";
			this.addWaybillButton.UseVisualStyleBackColor = true;
			this.addWaybillButton.Click += new System.EventHandler(this.addWaybillButton_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(80, 408);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(125, 31);
			this.button3.TabIndex = 15;
			this.button3.Text = "Редактировать";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Visible = false;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(546, 408);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(111, 31);
			this.button4.TabIndex = 14;
			this.button4.Text = "Удалить";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Visible = false;
			// 
			// busForm
			// 
			this.ClientSize = new System.Drawing.Size(744, 497);
			this.Controls.Add(this.MainTabControl);
			this.Name = "busForm";
			((System.ComponentModel.ISupportInitialize)(this.busesDataGridView)).EndInit();
			this.MainTabControl.ResumeLayout(false);
			this.busTabPage.ResumeLayout(false);
			this.cityTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).EndInit();
			this.driverTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.driverDataGridView)).EndInit();
			this.passangerTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.passangerDataGridView)).EndInit();
			this.routeTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.routeDataGridView)).EndInit();
			this.scheduleTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
			this.pasageTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.passagesDataGridView)).EndInit();
			this.ticketTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).EndInit();
			this.waybillTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.waybillDataGridView)).EndInit();
			this.ResumeLayout(false);

        }

        #region Bus

        private void AddBusButton_Click(object sender, EventArgs e)
        {
            AddBusForm addBusForm = new AddBusForm();

            DialogResult result = addBusForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            short valueSeatCount = 0;
            short.TryParse(addBusForm.busSeatCountTextBox.Text, out valueSeatCount);

            decimal valueCost = 0;
            decimal.TryParse(addBusForm.busCostTextBox.Text, out valueCost);

            Bus newBus = new Bus();
            newBus.VIN = addBusForm.VINTextBox.Text;
            newBus.Number = addBusForm.busNumberTextBox.Text;
            newBus.SeatCount = valueSeatCount;
            newBus.Cost = valueCost;

            _context.Buses.Add(newBus);

            _context.SaveChanges();
            MessageBox.Show("Новый объект добавлен");
        }

        private void DeleteBusButton_Click(object sender, EventArgs e)
        {
            if (busesDataGridView.SelectedRows.Count > 0)
            {
                if (busesDataGridView.SelectedRows.Count > 0)
                {
                    int index = busesDataGridView.SelectedRows[0].Index;
                    string vin = busesDataGridView[0, index].Value.ToString();
                
                    Bus bus = _context.Buses.Find(vin);
                    _context.Buses.Remove(bus);
                    _context.SaveChanges();

                    MessageBox.Show("Объект удален");
                }
            }
        }
        
        private void EditBusButton_Click(object sender, EventArgs e)
        {
            if (busesDataGridView.SelectedRows.Count > 0)
            {
                int index = busesDataGridView.SelectedRows[0].Index;
                string vin = busesDataGridView[0, index].Value.ToString();

                Bus bus = _context.Buses.Find(vin);

                AddBusForm addBusForm = new AddBusForm();

                addBusForm.VINTextBox.Text = bus.VIN.ToString();
                addBusForm.busNumberTextBox.Text = bus.Number.ToString();
                addBusForm.busSeatCountTextBox.Text = bus.SeatCount.ToString();
                addBusForm.busCostTextBox.Text = bus.Cost.ToString();

                DialogResult result = addBusForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                short valueSeatCount = 0;
                short.TryParse(addBusForm.busSeatCountTextBox.Text, out valueSeatCount);

                decimal valueCost = 0;
                decimal.TryParse(addBusForm.busCostTextBox.Text, out valueCost);

                bus.VIN = addBusForm.VINTextBox.Text;
                bus.Number = addBusForm.busNumberTextBox.Text;
                bus.SeatCount = valueSeatCount;
                bus.Cost = valueCost;

                _context.SaveChanges();
                busesDataGridView.Refresh(); // обновляем грид
                MessageBox.Show("Объект обновлен");
            }
        }

        #endregion

        #region City

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            AddCityForm addCityForm = new AddCityForm();

            DialogResult result = addCityForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            int valueNumber = 0;
            int.TryParse(addCityForm.cityNumberTextBox.Text, out valueNumber);


            City newCity = new City();
            newCity.CityNumber = valueNumber;
            newCity.CityName = addCityForm.cityNameTextBox.Text;

            _context.Cities.Add(newCity);
            _context.SaveChanges();
            MessageBox.Show("Новый объект добавлен");
        }

        private void DeleteCityButton_Click(object sender, EventArgs e)
        {
            if (cityDataGridView.SelectedRows.Count > 0)
            {
                if (cityDataGridView.SelectedRows.Count > 0)
                {
                    int index = cityDataGridView.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(cityDataGridView[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;

                    City city = _context.Cities.Find(id);
                    _context.Cities.Remove(city);
                    _context.SaveChanges();

                    MessageBox.Show("Объект удален");
                }
            }
        }

        private void EditCityButton_Click(object sender, EventArgs e)
        {
            if (cityDataGridView.SelectedRows.Count > 0)
            {
                int index = cityDataGridView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(cityDataGridView[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                City city = _context.Cities.Find(id);

                AddCityForm addCityForm = new AddCityForm();

                addCityForm.cityNumberTextBox.Text = city.CityNumber.ToString();
                addCityForm.cityNameTextBox.Text = city.CityName;

                DialogResult result = addCityForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                int valueNumber = 0;
                int.TryParse(addCityForm.cityNumberTextBox.Text, out valueNumber);

                city.CityNumber = valueNumber;
                city.CityName = addCityForm.cityNameTextBox.Text;
                _context.SaveChanges();
                cityDataGridView.Refresh(); // обновляем грид
                MessageBox.Show("Объект обновлен");
            }
        }

        #endregion

        #region Driver

        private void DriverAddButton_Click(object sender, EventArgs e)
        {
            AddDriverForm addDriverForm = new AddDriverForm();

            DialogResult result = addDriverForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Driver newDriver = new Driver();
            newDriver.SNILS = addDriverForm.SNILSTextBox.Text;
            newDriver.Passport = addDriverForm.pasportTextBox.Text;
            newDriver.FullName = addDriverForm.fullnameTextBox.Text;
            newDriver.Birthdate = addDriverForm.birthDatePicker.Value;
            newDriver.DriverLicence = addDriverForm.licenseNumberTextBox.Text;


            _context.Drivers.Add(newDriver);

            _context.SaveChanges();
            MessageBox.Show("Новый объект добавлен");
        }

        private void DriverEditButton_Click(object sender, EventArgs e)
        {
            if (driverDataGridView.SelectedRows.Count > 0)
            {
                int index = driverDataGridView.SelectedRows[0].Index;
                string snils = driverDataGridView[0, index].Value.ToString();
                
                Driver driver = _context.Drivers.Find(snils);

                AddDriverForm addDriverForm = new AddDriverForm();

                addDriverForm.SNILSTextBox.Text = driver.SNILS.ToString();
                addDriverForm.pasportTextBox.Text = driver.Passport.ToString();
                addDriverForm.fullnameTextBox.Text = driver.FullName;
                addDriverForm.licenseNumberTextBox.Text = driver.DriverLicence.ToString();
                addDriverForm.birthDatePicker.Value = driver.Birthdate;

                DialogResult result = addDriverForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                driver.SNILS = addDriverForm.SNILSTextBox.Text;
                driver.Passport = addDriverForm.pasportTextBox.Text;
                driver.FullName = addDriverForm.fullnameTextBox.Text;
                driver.Birthdate = addDriverForm.birthDatePicker.Value;
                driver.DriverLicence = addDriverForm.licenseNumberTextBox.Text;

                _context.SaveChanges();
                driverDataGridView.Refresh(); // обновляем грид
                MessageBox.Show("Объект обновлен");
            }
        }

        private void DriverDeleteButton_Click(object sender, EventArgs e)
        {
            if (driverDataGridView.SelectedRows.Count > 0)
            {
                if (driverDataGridView.SelectedRows.Count > 0)
                {
                    int index = driverDataGridView.SelectedRows[0].Index;
                    string snils = driverDataGridView[0, index].Value.ToString();

                    Driver driver = _context.Drivers.Find(snils);
                    _context.Drivers.Remove(driver);
                    _context.SaveChanges();

                    MessageBox.Show("Объект удален");
                }
            }
        }

        #endregion

        #region Passanger

        private void PassangerAddButton_Click(object sender, EventArgs e)
        {
            AddPassangerForm addPassengerForm = new AddPassangerForm();

            DialogResult result = addPassengerForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            

            Passanger passanger = new Passanger();
            
            passanger.Passport = addPassengerForm.pasportTextBox.Text;
            passanger.FullName = addPassengerForm.fullnameTextBox.Text;
            passanger.BirthDate = addPassengerForm.birthDatePicker.Value;

            _context.Passangers.Add(passanger);

            _context.SaveChanges();
            MessageBox.Show("Новый объект добавлен");
        }

        private void PassangerEditButton_Click(object sender, EventArgs e)
        {
             if (passangerDataGridView.SelectedRows.Count > 0)
            {
                int index = passangerDataGridView.SelectedRows[0].Index;
                string passport = passangerDataGridView[0, index].Value.ToString();            

                Passanger passanger = _context.Passangers.Find(passport);

                AddPassangerForm addPassengerForm = new AddPassangerForm();

                
                addPassengerForm.pasportTextBox.Text = passanger.Passport.ToString();
                addPassengerForm.fullnameTextBox.Text = passanger.FullName;
                addPassengerForm.birthDatePicker.Value = passanger.BirthDate;

                DialogResult result = addPassengerForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                
                int valuePassport = 0;
                int.TryParse(addPassengerForm.pasportTextBox.Text, out valuePassport);

                passanger.Passport = addPassengerForm.pasportTextBox.Text;
                passanger.FullName = addPassengerForm.fullnameTextBox.Text;
                passanger.BirthDate = addPassengerForm.birthDatePicker.Value;
               

                _context.SaveChanges();
                passangerDataGridView.Refresh(); // обновляем грид
                MessageBox.Show("Объект обновлен");
            }
        }

        private void PassangerDeleteButton_Click(object sender, EventArgs e)
        {
           
                if (passangerDataGridView.SelectedRows.Count > 0)
                {
                    int index = passangerDataGridView.SelectedRows[0].Index;
                    string passport = passangerDataGridView[0, index].Value.ToString();

                    Passanger passanger = _context.Passangers.Find(passport);
                    _context.Passangers.Remove(passanger);
                    _context.SaveChanges();

                    MessageBox.Show("Объект удален");
                }
            }

        #endregion

        #region Route 

        private void AddRouteButton_Click(object sender, EventArgs e)
        {
            AddRouteForm addRouteForm = new AddRouteForm();

            addRouteForm.cityFromСomboBox.DataSource = _context.Cities.ToList();
            addRouteForm.cityToСomboBox.DataSource = _context.Cities.ToList();

            DialogResult result = addRouteForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            int routeNumberValue = 0;
            int.TryParse(addRouteForm.routeNumberTextBox.Text, out routeNumberValue);

            int routeKMValue = 0;
            int.TryParse(addRouteForm.routeKMTextBox.Text, out routeKMValue);

            Route newRoute = new Route();
            newRoute.RouteNumber = routeNumberValue;
            newRoute.KM = routeKMValue;
            newRoute.City = addRouteForm.cityFromСomboBox.SelectedItem as City;
            newRoute.City1 = addRouteForm.cityToСomboBox.SelectedItem as City;

            _context.Routes.Add(newRoute);
            _context.SaveChanges();

            MessageBox.Show("Новый объект добавлен");
        }

        private void EditRouteButton_Click(object sender, EventArgs e)
        {
            int index = routeDataGridView.SelectedRows[0].Index;
            int routeNumber = 0;
            bool converted = Int32.TryParse(routeDataGridView[0, index].Value.ToString(), out routeNumber);

            if (converted == false)
                return;

            Route route = _context.Routes.Find(routeNumber);

            AddRouteForm addRouteForm = new AddRouteForm();

            addRouteForm.cityFromСomboBox.DataSource = _context.Cities.ToList();
            addRouteForm.cityToСomboBox.DataSource = _context.Cities.ToList();

            addRouteForm.routeNumberTextBox.Text = route.RouteNumber.ToString();
            addRouteForm.routeKMTextBox.Text = route.KM.ToString();

            addRouteForm.cityFromСomboBox.SelectedIndex = _context.Cities.ToList().IndexOf(route.City);
            addRouteForm.cityToСomboBox.SelectedIndex = _context.Cities.ToList().IndexOf(route.City1);

            DialogResult result = addRouteForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            int routeNumberValue = 0;
            int.TryParse(addRouteForm.routeNumberTextBox.Text, out routeNumberValue);

            int routeKMValue = 0;
            int.TryParse(addRouteForm.routeKMTextBox.Text, out routeKMValue);

            route.RouteNumber = routeNumberValue;
            route.KM = routeKMValue;
            route.City = addRouteForm.cityFromСomboBox.SelectedItem as City;
            route.City1 = addRouteForm.cityToСomboBox.SelectedItem as City;

            
            _context.SaveChanges();
            routeDataGridView.Refresh();
            MessageBox.Show("Объект обновлён");
        }

        private void DeleteRouteButton_Click(object sender, EventArgs e)
        {
            if (routeDataGridView.SelectedRows.Count > 0)
            {
                if (routeDataGridView.SelectedRows.Count > 0)
                {
                    int index = routeDataGridView.SelectedRows[0].Index;
                    int routeNumber = 0;
                    bool converted = Int32.TryParse(routeDataGridView[0, index].Value.ToString(), out routeNumber);

                    if (converted == false)
                        return;

                    Route route = _context.Routes.Find(routeNumber);
                    _context.Routes.Remove(route);
                    _context.SaveChanges();
                    MessageBox.Show("Объект удален");
                }
            }
        }


        #endregion

        #region Schedule

        private void ScheduleAddButton_Click(object sender, EventArgs e)
        {
            AddScheduleForm addScheduleForm = new AddScheduleForm();
            addScheduleForm.routeСomboBox.DataSource = _context.Routes.Local.ToList();            
            
            DialogResult result = addScheduleForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            Schedule newSchedule = new Schedule();
            newSchedule.Route = addScheduleForm.routeСomboBox.SelectedItem as Route;
            newSchedule.RouteNumber = newSchedule.Route.RouteNumber;
            newSchedule.DepartureTime = TimeSpan.Parse(addScheduleForm.timeMaskedTextBox.Text);

            _context.Schedules.Add(newSchedule);
            _context.SaveChanges();

            MessageBox.Show("Новый объект добавлен");
        }

        private void ScheduleEditButton_Click(object sender, EventArgs e)
        {
            
            if (scheduleDataGridView.SelectedRows.Count > 0)
            {
                int index = scheduleDataGridView.SelectedRows[0].Index;
                int routeNumber = 0;
                TimeSpan time = TimeSpan.Zero;

                bool converted = Int32.TryParse(scheduleDataGridView["RouteNumber", index].Value.ToString(), out routeNumber)
                    && TimeSpan.TryParse(scheduleDataGridView["DepartureTime", index].Value.ToString(), out time);

                if (converted == false)
                    return;

                Schedule schedule = _context.Schedules.Find(time, routeNumber);

                AddScheduleForm addScheduleForm = new AddScheduleForm();
                addScheduleForm.routeСomboBox.DataSource = _context.Routes.Local.ToList();

                addScheduleForm.timeMaskedTextBox.Text = schedule.DepartureTime.ToString();
                addScheduleForm.routeСomboBox.SelectedIndex = _context.Routes.Local.ToList().IndexOf(schedule.Route);

                DialogResult result = addScheduleForm.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                schedule.Route = addScheduleForm.routeСomboBox.SelectedItem as Route;
                schedule.RouteNumber = schedule.Route.RouteNumber;
                schedule.DepartureTime = TimeSpan.Parse(addScheduleForm.timeMaskedTextBox.Text);

                _context.SaveChanges();
                scheduleDataGridView.Refresh();
                MessageBox.Show("Объект обновлён");
            }
        }

        private void ScheduleDeleteButton_Click(object sender, EventArgs e)
        {
            
                if (scheduleDataGridView.SelectedRows.Count > 0)
                {
                    int index = scheduleDataGridView.SelectedRows[0].Index;
                    int routeNumber = 0;
                    TimeSpan time = TimeSpan.Zero;

                    bool converted = Int32.TryParse(scheduleDataGridView["RouteNumber", index].Value.ToString(), out routeNumber)
                        && TimeSpan.TryParse(scheduleDataGridView["DepartureTime", index].Value.ToString(), out time);

                    if (converted == false)
                        return;

                    Schedule schedule = _context.Schedules.Find(time, routeNumber);
                    _context.Schedules.Remove(schedule);
                    _context.SaveChanges();
                    MessageBox.Show("Объект удален");
                }
            
        }


        #endregion

        #region Passage

        private void AddPassageButton_Click(object sender, EventArgs e)
        {
            AddPassageForm addPassageForm = new AddPassageForm();

            addPassageForm.routeСomboBox.DataSource = _context.Schedules.Local.ToList();
            addPassageForm.busСomboBox.DataSource = _context.Buses.Local.ToList();

            DialogResult result = addPassageForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            Passage newPassage = new Passage();
            newPassage.Schedule = addPassageForm.routeСomboBox.SelectedItem as Schedule;
            newPassage.Bus = addPassageForm.busСomboBox.SelectedItem as Bus;
            newPassage.DepartureTime = newPassage.Schedule.DepartureTime;
            newPassage.RouteNumber = newPassage.Schedule.RouteNumber;
            newPassage.Date = addPassageForm.dateTimePicker.Value.Date;

            _context.Passages.Add(newPassage);
            _context.SaveChanges();
            
            MessageBox.Show("Новый объект добавлен");
        }

        private void EditPassageButton_Click(object sender, EventArgs e)
        {

        }



		#endregion

		private void AddTicketButton_Click(object sender, EventArgs e)
		{
			AddTicketForm addTicketForm = new AddTicketForm();

			if (_context.Tickets.Count() == 0)
				addTicketForm.ticketNumberLabel.Text = "1";
			else
				addTicketForm.ticketNumberLabel.Text = (_context.Tickets.Max(t => t.TicketNumber) + 1).ToString();

			_context.Passages.Load();

			addTicketForm.passageComboBox.DataSource = _context.Passages.Local.Where(p => p.Tickets.Count < p.Bus.SeatCount).ToList();
			addTicketForm.passangerComboBox.DataSource = _context.Passangers.Local.ToList();

			DialogResult result = addTicketForm.ShowDialog(this);
			if (result == DialogResult.Cancel)
				return;

			Ticket newTicket = new Ticket();
			newTicket.Passage = addTicketForm.passageComboBox.SelectedItem as Passage;
			newTicket.Passanger = addTicketForm.passangerComboBox.SelectedItem as Passanger;
			newTicket.TicketNumber =  int.Parse(addTicketForm.ticketNumberLabel.Text);

			_context.Tickets.Add(newTicket);
			_context.SaveChanges();

			MessageBox.Show("Новый объект добавлен");
		}

		private void addWaybillButton_Click(object sender, EventArgs e)
		{
			AddWaybillForm addWaybillForm = new AddWaybillForm();

			int waybillNumber = 1;
			if (_context.Waybills.Count() == 0)
				addWaybillForm.waybillNumberTextBox.Text = waybillNumber.ToString();
			else
				addWaybillForm.waybillNumberTextBox.Text = (waybillNumber = int.Parse(_context.Waybills.Max(w => w.WaybillNumber)) + 1).ToString();

			_context.Passages.Load();

			addWaybillForm.driverComboBox.DataSource = _context.Drivers.Local.ToList();
			addWaybillForm.passageComboBox.DataSource = _context.Passages.Local.Except(_context.Waybills.Select(w => w.Passage)).ToList();

			DialogResult result = addWaybillForm.ShowDialog(this);
			if (result == DialogResult.Cancel)
				return;

			Waybill newWaybill = new Waybill();

			newWaybill.WaybillNumber = waybillNumber.ToString();
			newWaybill.SNILS = (addWaybillForm.driverComboBox.SelectedItem as Driver).SNILS;
			Passage p = addWaybillForm.passageComboBox.SelectedItem as Passage;
			newWaybill.RouteNumber = p.RouteNumber;
			newWaybill.Date = p.Date;
			newWaybill.DepartureTime = p.DepartureTime;

			_context.Waybills.Add(newWaybill);
			_context.SaveChanges();

			MessageBox.Show("Новый объект добавлен");
		}

		private void RemoveTicketButton_Click(object sender, EventArgs e)
		{
			if (ticketsDataGridView.SelectedRows.Count > 0)
			{
				if (ticketsDataGridView.SelectedRows.Count > 0)
				{
					int index = ticketsDataGridView.SelectedRows[0].Index;
					int routeNumber = 0;
					bool converted = Int32.TryParse(routeDataGridView[0, index].Value.ToString(), out routeNumber);

					if (converted == false)
						return;

					Ticket ticket = _context.Tickets.Find(routeNumber);
					_context.Tickets.Remove(ticket);
					_context.SaveChanges();
					MessageBox.Show("Объект удален");
				}
			}
		}
	}
}
