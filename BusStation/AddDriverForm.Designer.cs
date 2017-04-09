namespace BusStation
{
    partial class AddDriverForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.addBusButton = new System.Windows.Forms.Button();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.pasportTextBox = new System.Windows.Forms.TextBox();
            this.SNILSTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VINLabel = new System.Windows.Forms.Label();
            this.licenseNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(328, 437);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 39);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addBusButton
            // 
            this.addBusButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addBusButton.Location = new System.Drawing.Point(117, 437);
            this.addBusButton.Name = "addBusButton";
            this.addBusButton.Size = new System.Drawing.Size(107, 39);
            this.addBusButton.TabIndex = 18;
            this.addBusButton.Text = "OK";
            this.addBusButton.UseVisualStyleBackColor = true;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Location = new System.Drawing.Point(298, 200);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(274, 22);
            this.fullnameTextBox.TabIndex = 16;
            // 
            // pasportTextBox
            // 
            this.pasportTextBox.Location = new System.Drawing.Point(298, 141);
            this.pasportTextBox.Name = "pasportTextBox";
            this.pasportTextBox.Size = new System.Drawing.Size(274, 22);
            this.pasportTextBox.TabIndex = 15;
            // 
            // SNILSTextBox
            // 
            this.SNILSTextBox.Location = new System.Drawing.Point(298, 94);
            this.SNILSTextBox.Name = "SNILSTextBox";
            this.SNILSTextBox.Size = new System.Drawing.Size(274, 22);
            this.SNILSTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Паспорт:";
            // 
            // VINLabel
            // 
            this.VINLabel.Location = new System.Drawing.Point(70, 94);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(175, 21);
            this.VINLabel.TabIndex = 10;
            this.VINLabel.Text = "СНИЛС:";
            // 
            // licenseNumberTextBox
            // 
            this.licenseNumberTextBox.Location = new System.Drawing.Point(298, 353);
            this.licenseNumberTextBox.Name = "licenseNumberTextBox";
            this.licenseNumberTextBox.Size = new System.Drawing.Size(274, 22);
            this.licenseNumberTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Номер лицензии:";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(309, 256);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(200, 22);
            this.birthDatePicker.TabIndex = 23;
            // 
            // AddDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 528);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.licenseNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addBusButton);
            this.Controls.Add(this.fullnameTextBox);
            this.Controls.Add(this.pasportTextBox);
            this.Controls.Add(this.SNILSTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VINLabel);
            this.Name = "AddDriverForm";
            this.Text = "Водитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Button addBusButton;
        public System.Windows.Forms.TextBox fullnameTextBox;
        public System.Windows.Forms.TextBox pasportTextBox;
        public System.Windows.Forms.TextBox SNILSTextBox;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label VINLabel;
        public System.Windows.Forms.TextBox licenseNumberTextBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker birthDatePicker;
    }
}