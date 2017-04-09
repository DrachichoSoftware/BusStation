namespace BusStation
{
    partial class AddCityForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addBusButton = new System.Windows.Forms.Button();
            this.cityNumberTextBox = new System.Windows.Forms.TextBox();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер города:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название города:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(205, 203);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 39);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addBusButton
            // 
            this.addBusButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addBusButton.Location = new System.Drawing.Point(49, 203);
            this.addBusButton.Name = "addBusButton";
            this.addBusButton.Size = new System.Drawing.Size(107, 39);
            this.addBusButton.TabIndex = 10;
            this.addBusButton.Text = "OK";
            this.addBusButton.UseVisualStyleBackColor = true;
            // 
            // cityNumberTextBox
            // 
            this.cityNumberTextBox.Location = new System.Drawing.Point(205, 58);
            this.cityNumberTextBox.Name = "cityNumberTextBox";
            this.cityNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityNumberTextBox.TabIndex = 12;
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Location = new System.Drawing.Point(205, 131);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityNameTextBox.TabIndex = 13;
            // 
            // AddCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 280);
            this.Controls.Add(this.cityNameTextBox);
            this.Controls.Add(this.cityNumberTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addBusButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCityForm";
            this.Text = "Город";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Button addBusButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox cityNumberTextBox;
        public System.Windows.Forms.TextBox cityNameTextBox;
    }
}