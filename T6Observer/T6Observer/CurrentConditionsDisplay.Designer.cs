namespace T6Observer
{
    partial class CurrentConditionsDisplay
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.btnRegisterAsObserver = new System.Windows.Forms.Button();
            this.btnDeRegisterAsObserver = new System.Windows.Forms.Button();
            this.btnFetch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Conditions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Humidity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pressure";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(147, 62);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(79, 13);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "____________";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(147, 89);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(79, 13);
            this.lblHumidity.TabIndex = 5;
            this.lblHumidity.Text = "____________";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(147, 116);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(79, 13);
            this.lblPressure.TabIndex = 6;
            this.lblPressure.Text = "____________";
            // 
            // btnRegisterAsObserver
            // 
            this.btnRegisterAsObserver.Location = new System.Drawing.Point(72, 173);
            this.btnRegisterAsObserver.Name = "btnRegisterAsObserver";
            this.btnRegisterAsObserver.Size = new System.Drawing.Size(140, 23);
            this.btnRegisterAsObserver.TabIndex = 7;
            this.btnRegisterAsObserver.Text = "Register As Observer";
            this.btnRegisterAsObserver.UseVisualStyleBackColor = true;
            this.btnRegisterAsObserver.Click += new System.EventHandler(this.btnRegisterAsObserver_Click);
            // 
            // btnDeRegisterAsObserver
            // 
            this.btnDeRegisterAsObserver.Location = new System.Drawing.Point(72, 215);
            this.btnDeRegisterAsObserver.Name = "btnDeRegisterAsObserver";
            this.btnDeRegisterAsObserver.Size = new System.Drawing.Size(140, 23);
            this.btnDeRegisterAsObserver.TabIndex = 8;
            this.btnDeRegisterAsObserver.Text = "De-Register As Observer";
            this.btnDeRegisterAsObserver.UseVisualStyleBackColor = true;
            this.btnDeRegisterAsObserver.Click += new System.EventHandler(this.btnDeRegisterAsObserver_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(186, 144);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(75, 23);
            this.btnFetch.TabIndex = 9;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // CurrentConditionsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.btnDeRegisterAsObserver);
            this.Controls.Add(this.btnRegisterAsObserver);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CurrentConditionsDisplay";
            this.Text = "CurrentConditionsDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Button btnRegisterAsObserver;
        private System.Windows.Forms.Button btnDeRegisterAsObserver;
        private System.Windows.Forms.Button btnFetch;
    }
}