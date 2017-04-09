namespace BusStation
{
    partial class AddRouteForm
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
            this.addRouteButton = new System.Windows.Forms.Button();
            this.routeKMTextBox = new System.Windows.Forms.TextBox();
            this.routeNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cityFromСomboBox = new System.Windows.Forms.ComboBox();
            this.cityToСomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(310, 279);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 39);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addRouteButton
            // 
            this.addRouteButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addRouteButton.Location = new System.Drawing.Point(114, 279);
            this.addRouteButton.Name = "addRouteButton";
            this.addRouteButton.Size = new System.Drawing.Size(107, 39);
            this.addRouteButton.TabIndex = 32;
            this.addRouteButton.Text = "OK";
            this.addRouteButton.UseVisualStyleBackColor = true;
            // 
            // routeKMTextBox
            // 
            this.routeKMTextBox.Location = new System.Drawing.Point(249, 125);
            this.routeKMTextBox.Name = "routeKMTextBox";
            this.routeKMTextBox.Size = new System.Drawing.Size(274, 22);
            this.routeKMTextBox.TabIndex = 37;
            // 
            // routeNumberTextBox
            // 
            this.routeNumberTextBox.Location = new System.Drawing.Point(249, 66);
            this.routeNumberTextBox.Name = "routeNumberTextBox";
            this.routeNumberTextBox.Size = new System.Drawing.Size(274, 22);
            this.routeNumberTextBox.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Расстояние (км):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Номер маршрута:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Откуда:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Куда: ";
            // 
            // cityFromСomboBox
            // 
            this.cityFromСomboBox.FormattingEnabled = true;
            this.cityFromСomboBox.Location = new System.Drawing.Point(249, 173);
            this.cityFromСomboBox.Name = "cityFromСomboBox";
            this.cityFromСomboBox.Size = new System.Drawing.Size(121, 24);
            this.cityFromСomboBox.TabIndex = 40;
            // 
            // cityToСomboBox
            // 
            this.cityToСomboBox.FormattingEnabled = true;
            this.cityToСomboBox.Location = new System.Drawing.Point(249, 227);
            this.cityToСomboBox.Name = "cityToСomboBox";
            this.cityToСomboBox.Size = new System.Drawing.Size(121, 24);
            this.cityToСomboBox.TabIndex = 41;
            // 
            // AddRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 349);
            this.Controls.Add(this.cityToСomboBox);
            this.Controls.Add(this.cityFromСomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.routeKMTextBox);
            this.Controls.Add(this.routeNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addRouteButton);
            this.Name = "AddRouteForm";
            this.Text = "Маршруты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Button addRouteButton;
        public System.Windows.Forms.TextBox routeKMTextBox;
        public System.Windows.Forms.TextBox routeNumberTextBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cityFromСomboBox;
        public System.Windows.Forms.ComboBox cityToСomboBox;
    }
}