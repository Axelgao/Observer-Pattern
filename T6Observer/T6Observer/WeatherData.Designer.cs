namespace T6Observer
{
    partial class WeatherData
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
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPressure = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weather Station";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temp";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(114, 74);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 2;
            this.txtTemp.Leave += new System.EventHandler(this.txtTemp_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Humidity";
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(114, 127);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(100, 20);
            this.txtHumidity.TabIndex = 4;
            this.txtHumidity.Leave += new System.EventHandler(this.txtHumidity_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pressure";
            // 
            // txtPressure
            // 
            this.txtPressure.Location = new System.Drawing.Point(114, 182);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(100, 20);
            this.txtPressure.TabIndex = 6;
            this.txtPressure.Leave += new System.EventHandler(this.txtPressure_Leave);
            // 
            // WeatherData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtPressure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHumidity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WeatherData";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPressure;
    }
}

