namespace BusStation
{
    partial class AddPassangerForm
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
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.pasportTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addBusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(265, 196);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(200, 22);
            this.birthDatePicker.TabIndex = 29;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Location = new System.Drawing.Point(254, 140);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(274, 22);
            this.fullnameTextBox.TabIndex = 28;
            // 
            // pasportTextBox
            // 
            this.pasportTextBox.Location = new System.Drawing.Point(254, 81);
            this.pasportTextBox.Name = "pasportTextBox";
            this.pasportTextBox.Size = new System.Drawing.Size(274, 22);
            this.pasportTextBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Паспорт:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(265, 272);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 39);
            this.cancelButton.TabIndex = 31;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addBusButton
            // 
            this.addBusButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addBusButton.Location = new System.Drawing.Point(69, 272);
            this.addBusButton.Name = "addBusButton";
            this.addBusButton.Size = new System.Drawing.Size(107, 39);
            this.addBusButton.TabIndex = 30;
            this.addBusButton.Text = "OK";
            this.addBusButton.UseVisualStyleBackColor = true;
            // 
            // AddPassangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 338);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addBusButton);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.fullnameTextBox);
            this.Controls.Add(this.pasportTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddPassangerForm";
            this.Text = "Пассажир";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker birthDatePicker;
        public System.Windows.Forms.TextBox fullnameTextBox;
        public System.Windows.Forms.TextBox pasportTextBox;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Button addBusButton;
    }
}