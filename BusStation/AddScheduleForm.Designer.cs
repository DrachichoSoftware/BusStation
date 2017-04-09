namespace BusStation
{
    partial class AddScheduleForm
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
            this.addScheduleButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.routeСomboBox = new System.Windows.Forms.ComboBox();
            this.timeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(296, 302);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 39);
            this.cancelButton.TabIndex = 35;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addScheduleButton
            // 
            this.addScheduleButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addScheduleButton.Location = new System.Drawing.Point(100, 302);
            this.addScheduleButton.Name = "addScheduleButton";
            this.addScheduleButton.Size = new System.Drawing.Size(107, 39);
            this.addScheduleButton.TabIndex = 34;
            this.addScheduleButton.Text = "OK";
            this.addScheduleButton.UseVisualStyleBackColor = true;
            this.addScheduleButton.Click += new System.EventHandler(this.addScheduleButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Время отправления:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Маршрут:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // routeСomboBox
            // 
            this.routeСomboBox.FormattingEnabled = true;
            this.routeСomboBox.Location = new System.Drawing.Point(296, 109);
            this.routeСomboBox.Name = "routeСomboBox";
            this.routeСomboBox.Size = new System.Drawing.Size(341, 24);
            this.routeСomboBox.TabIndex = 36;
            this.routeСomboBox.SelectedIndexChanged += new System.EventHandler(this.routeСomboBox_SelectedIndexChanged);
            // 
            // timeMaskedTextBox
            // 
            this.timeMaskedTextBox.Location = new System.Drawing.Point(296, 218);
            this.timeMaskedTextBox.Mask = "00:00";
            this.timeMaskedTextBox.Name = "timeMaskedTextBox";
            this.timeMaskedTextBox.Size = new System.Drawing.Size(103, 22);
            this.timeMaskedTextBox.TabIndex = 37;
            this.timeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.timeMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.timeMaskedTextBox_Validating);
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 371);
            this.Controls.Add(this.timeMaskedTextBox);
            this.Controls.Add(this.routeСomboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addScheduleButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddScheduleForm";
            this.Text = "Расписание";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddScheduleForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Button addScheduleButton;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox routeСomboBox;
        public System.Windows.Forms.MaskedTextBox timeMaskedTextBox;
    }
}