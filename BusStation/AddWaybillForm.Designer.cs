namespace BusStation
{
	partial class AddWaybillForm
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
			this.CancelButton = new System.Windows.Forms.Button();
			this.OKButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.driverComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.waybillNumberTextBox = new System.Windows.Forms.Label();
			this.passageComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// CancelButton
			// 
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(242, 165);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 10;
			this.CancelButton.Text = "Отмена";
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// OKButton
			// 
			this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OKButton.Location = new System.Drawing.Point(41, 165);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 9;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Водитель: ";
			// 
			// driverComboBox
			// 
			this.driverComboBox.FormattingEnabled = true;
			this.driverComboBox.Location = new System.Drawing.Point(183, 61);
			this.driverComboBox.Name = "driverComboBox";
			this.driverComboBox.Size = new System.Drawing.Size(153, 21);
			this.driverComboBox.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Рейс: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Номер путевого листа: ";
			// 
			// waybillNumberTextBox
			// 
			this.waybillNumberTextBox.AutoSize = true;
			this.waybillNumberTextBox.Location = new System.Drawing.Point(180, 23);
			this.waybillNumberTextBox.Name = "waybillNumberTextBox";
			this.waybillNumberTextBox.Size = new System.Drawing.Size(0, 13);
			this.waybillNumberTextBox.TabIndex = 16;
			// 
			// passageComboBox
			// 
			this.passageComboBox.FormattingEnabled = true;
			this.passageComboBox.Location = new System.Drawing.Point(183, 114);
			this.passageComboBox.Name = "passageComboBox";
			this.passageComboBox.Size = new System.Drawing.Size(153, 21);
			this.passageComboBox.TabIndex = 17;
			// 
			// AddWaybillForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 200);
			this.Controls.Add(this.passageComboBox);
			this.Controls.Add(this.waybillNumberTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.driverComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OKButton);
			this.Name = "AddWaybillForm";
			this.Text = "AddWaybillForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Button CancelButton;
		public System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.ComboBox driverComboBox;
		public System.Windows.Forms.Label waybillNumberTextBox;
		public System.Windows.Forms.ComboBox passageComboBox;
	}
}