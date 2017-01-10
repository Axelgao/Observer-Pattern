namespace T6Observer
{
    partial class ForecastDisplay
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
            this.lblForecast = new System.Windows.Forms.Label();
            this.btnRegisterAsObserver = new System.Windows.Forms.Button();
            this.btnDeRegisterAsObserver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forecast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expected Conditions:";
            // 
            // lblForecast
            // 
            this.lblForecast.AutoSize = true;
            this.lblForecast.Location = new System.Drawing.Point(172, 90);
            this.lblForecast.Name = "lblForecast";
            this.lblForecast.Size = new System.Drawing.Size(55, 13);
            this.lblForecast.TabIndex = 2;
            this.lblForecast.Text = "________";
            // 
            // btnRegisterAsObserver
            // 
            this.btnRegisterAsObserver.Location = new System.Drawing.Point(68, 171);
            this.btnRegisterAsObserver.Name = "btnRegisterAsObserver";
            this.btnRegisterAsObserver.Size = new System.Drawing.Size(149, 23);
            this.btnRegisterAsObserver.TabIndex = 3;
            this.btnRegisterAsObserver.Text = "Register As Observer";
            this.btnRegisterAsObserver.UseVisualStyleBackColor = true;
            this.btnRegisterAsObserver.Click += new System.EventHandler(this.btnRegisterAsObserver_Click);
            // 
            // btnDeRegisterAsObserver
            // 
            this.btnDeRegisterAsObserver.Location = new System.Drawing.Point(68, 217);
            this.btnDeRegisterAsObserver.Name = "btnDeRegisterAsObserver";
            this.btnDeRegisterAsObserver.Size = new System.Drawing.Size(149, 23);
            this.btnDeRegisterAsObserver.TabIndex = 4;
            this.btnDeRegisterAsObserver.Text = "De-Register As Observer";
            this.btnDeRegisterAsObserver.UseVisualStyleBackColor = true;
            this.btnDeRegisterAsObserver.Click += new System.EventHandler(this.btnDeRegisterAsObserver_Click);
            // 
            // ForecastDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDeRegisterAsObserver);
            this.Controls.Add(this.btnRegisterAsObserver);
            this.Controls.Add(this.lblForecast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForecastDisplay";
            this.Text = "ForecastDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblForecast;
        private System.Windows.Forms.Button btnRegisterAsObserver;
        private System.Windows.Forms.Button btnDeRegisterAsObserver;
    }
}