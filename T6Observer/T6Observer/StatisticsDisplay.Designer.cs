namespace T6Observer
{
    partial class StatisticsDisplay
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
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.btnRegisterAsObserver = new System.Windows.Forms.Button();
            this.btnDeRegisterAsObserver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weather Statistics ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max Temp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Min Temp";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(154, 69);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(55, 13);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "________";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(154, 100);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(55, 13);
            this.lblMax.TabIndex = 5;
            this.lblMax.Text = "________";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(154, 130);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(55, 13);
            this.lblMin.TabIndex = 6;
            this.lblMin.Text = "________";
            // 
            // btnRegisterAsObserver
            // 
            this.btnRegisterAsObserver.Location = new System.Drawing.Point(68, 170);
            this.btnRegisterAsObserver.Name = "btnRegisterAsObserver";
            this.btnRegisterAsObserver.Size = new System.Drawing.Size(148, 23);
            this.btnRegisterAsObserver.TabIndex = 7;
            this.btnRegisterAsObserver.Text = "Register As Observer";
            this.btnRegisterAsObserver.UseVisualStyleBackColor = true;
            this.btnRegisterAsObserver.Click += new System.EventHandler(this.btnRegisterAsObserver_Click);
            // 
            // btnDeRegisterAsObserver
            // 
            this.btnDeRegisterAsObserver.Location = new System.Drawing.Point(68, 209);
            this.btnDeRegisterAsObserver.Name = "btnDeRegisterAsObserver";
            this.btnDeRegisterAsObserver.Size = new System.Drawing.Size(148, 23);
            this.btnDeRegisterAsObserver.TabIndex = 8;
            this.btnDeRegisterAsObserver.Text = "De-Register As Observer";
            this.btnDeRegisterAsObserver.UseVisualStyleBackColor = true;
            this.btnDeRegisterAsObserver.Click += new System.EventHandler(this.btnDeRegisterAsObserver_Click);
            // 
            // StatisticsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDeRegisterAsObserver);
            this.Controls.Add(this.btnRegisterAsObserver);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StatisticsDisplay";
            this.Text = "StatisticsDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Button btnRegisterAsObserver;
        private System.Windows.Forms.Button btnDeRegisterAsObserver;
    }
}