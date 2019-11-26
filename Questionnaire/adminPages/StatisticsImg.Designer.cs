namespace Questionnaire.adminPages
{
    partial class StatisticsImg
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
            this.flp_Charts = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flp_Charts
            // 
            this.flp_Charts.AutoScroll = true;
            this.flp_Charts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_Charts.Location = new System.Drawing.Point(0, 55);
            this.flp_Charts.Name = "flp_Charts";
            this.flp_Charts.Size = new System.Drawing.Size(800, 457);
            this.flp_Charts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F);
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据统计";
            // 
            // StatisticsImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flp_Charts);
            this.Name = "StatisticsImg";
            this.Text = "StatisticsImg";
            this.Load += new System.EventHandler(this.StatisticsImg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_Charts;
        private System.Windows.Forms.Label label1;
    }
}