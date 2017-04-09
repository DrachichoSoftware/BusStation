namespace BusStation
{
	partial class AddTicketForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.passageComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.passangerComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.ticketNumberLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// passageComboBox
			// 
			this.passageComboBox.FormattingEnabled = true;
			this.passageComboBox.Location = new System.Drawing.Point(144, 91);
			this.passageComboBox.Name = "passageComboBox";
			this.passageComboBox.Size = new System.Drawing.Size(226, 21);
			this.passageComboBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Рейс:";
			// 
			// passangerComboBox
			// 
			this.passangerComboBox.FormattingEnabled = true;
			this.passangerComboBox.Location = new System.Drawing.Point(144, 147);
			this.passangerComboBox.Name = "passangerComboBox";
			this.passangerComboBox.Size = new System.Drawing.Size(226, 21);
			this.passangerComboBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Номер билета:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Пассажир:";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(54, 207);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(255, 207);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Отмена";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// ticketNumberLabel
			// 
			this.ticketNumberLabel.AutoSize = true;
			this.ticketNumberLabel.Location = new System.Drawing.Point(141, 42);
			this.ticketNumberLabel.Name = "ticketNumberLabel";
			this.ticketNumberLabel.Size = new System.Drawing.Size(0, 13);
			this.ticketNumberLabel.TabIndex = 9;
			// 
			// AddTicketForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 250);
			this.Controls.Add(this.ticketNumberLabel);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.passangerComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passageComboBox);
			this.Name = "AddTicketForm";
			this.Text = "Создать новый билет";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.Button button2;
		public System.Windows.Forms.ComboBox passageComboBox;
		public System.Windows.Forms.ComboBox passangerComboBox;
		public System.Windows.Forms.Label ticketNumberLabel;
	}
}