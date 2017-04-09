namespace BusStation
{
    partial class AddBusForm
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
            this.VINLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VINTextBox = new System.Windows.Forms.TextBox();
            this.busNumberTextBox = new System.Windows.Forms.TextBox();
            this.busSeatCountTextBox = new System.Windows.Forms.TextBox();
            this.busCostTextBox = new System.Windows.Forms.TextBox();
            this.addBusButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VINLabel
            // 
            this.VINLabel.Location = new System.Drawing.Point(34, 45);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(178, 66);
            this.VINLabel.TabIndex = 0;
            this.VINLabel.Text = "Идентификатор транпортного средства (VIN):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Регистрационный номер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество мест:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Стоимость места:";
            // 
            // VINTextBox
            // 
            this.VINTextBox.Location = new System.Drawing.Point(262, 76);
            this.VINTextBox.Name = "VINTextBox";
            this.VINTextBox.Size = new System.Drawing.Size(100, 22);
            this.VINTextBox.TabIndex = 4;
            // 
            // busNumberTextBox
            // 
            this.busNumberTextBox.Location = new System.Drawing.Point(262, 123);
            this.busNumberTextBox.Name = "busNumberTextBox";
            this.busNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.busNumberTextBox.TabIndex = 5;
            // 
            // busSeatCountTextBox
            // 
            this.busSeatCountTextBox.Location = new System.Drawing.Point(262, 182);
            this.busSeatCountTextBox.Name = "busSeatCountTextBox";
            this.busSeatCountTextBox.Size = new System.Drawing.Size(100, 22);
            this.busSeatCountTextBox.TabIndex = 6;
            // 
            // busCostTextBox
            // 
            this.busCostTextBox.Location = new System.Drawing.Point(262, 233);
            this.busCostTextBox.Name = "busCostTextBox";
            this.busCostTextBox.Size = new System.Drawing.Size(100, 22);
            this.busCostTextBox.TabIndex = 7;
            // 
            // addBusButton
            // 
            this.addBusButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addBusButton.Location = new System.Drawing.Point(52, 278);
            this.addBusButton.Name = "addBusButton";
            this.addBusButton.Size = new System.Drawing.Size(107, 39);
            this.addBusButton.TabIndex = 8;
            this.addBusButton.Text = "OK";
            this.addBusButton.UseVisualStyleBackColor = true;
            this.addBusButton.Click += new System.EventHandler(this.addBusButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(248, 278);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 39);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddBusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 345);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addBusButton);
            this.Controls.Add(this.busCostTextBox);
            this.Controls.Add(this.busSeatCountTextBox);
            this.Controls.Add(this.busNumberTextBox);
            this.Controls.Add(this.VINTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VINLabel);
            this.Name = "AddBusForm";
            this.Text = "Автобус";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label VINLabel;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox VINTextBox;
        public System.Windows.Forms.TextBox busNumberTextBox;
        public System.Windows.Forms.TextBox busSeatCountTextBox;
        public System.Windows.Forms.TextBox busCostTextBox;
        public System.Windows.Forms.Button addBusButton;
        public System.Windows.Forms.Button cancelButton;
    }
}