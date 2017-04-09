namespace BusStation
{
    partial class AddPassageForm
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
            this.routeСomboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addPassageButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.busСomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // routeСomboBox
            // 
            this.routeСomboBox.FormattingEnabled = true;
            this.routeСomboBox.Location = new System.Drawing.Point(266, 95);
            this.routeСomboBox.Name = "routeСomboBox";
            this.routeСomboBox.Size = new System.Drawing.Size(341, 24);
            this.routeСomboBox.TabIndex = 41;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(266, 361);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 39);
            this.cancelButton.TabIndex = 40;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addPassageButton
            // 
            this.addPassageButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addPassageButton.Location = new System.Drawing.Point(70, 361);
            this.addPassageButton.Name = "addPassageButton";
            this.addPassageButton.Size = new System.Drawing.Size(107, 39);
            this.addPassageButton.TabIndex = 39;
            this.addPassageButton.Text = "OK";
            this.addPassageButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Дата отправления:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Маршрут из расписания:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(266, 200);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 42;
            // 
            // busСomboBox
            // 
            this.busСomboBox.FormattingEnabled = true;
            this.busСomboBox.Location = new System.Drawing.Point(266, 272);
            this.busСomboBox.Name = "busСomboBox";
            this.busСomboBox.Size = new System.Drawing.Size(341, 24);
            this.busСomboBox.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Транспортное средство:";
            // 
            // AddPassageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 445);
            this.Controls.Add(this.busСomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.routeСomboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addPassageButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddPassageForm";
            this.Text = "Рейс";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox routeСomboBox;
        public System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Button addPassageButton;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox busСomboBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}