namespace Questionnaire.UserPages
{
    partial class UserStartPage
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
            this.btn_Open = new System.Windows.Forms.Button();
            this.t_questionnaireID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F);
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "问卷ID：";
            // 
            // btn_Open
            // 
            this.btn_Open.Font = new System.Drawing.Font("宋体", 18F);
            this.btn_Open.Location = new System.Drawing.Point(392, 43);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 38);
            this.btn_Open.TabIndex = 2;
            this.btn_Open.Text = "打开";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // t_questionnaireID
            // 
            this.t_questionnaireID.Font = new System.Drawing.Font("宋体", 22F);
            this.t_questionnaireID.Location = new System.Drawing.Point(134, 40);
            this.t_questionnaireID.Name = "t_questionnaireID";
            this.t_questionnaireID.Size = new System.Drawing.Size(238, 41);
            this.t_questionnaireID.TabIndex = 1;
            this.t_questionnaireID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_questionnaireID_KeyPress);
            // 
            // UserStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 111);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.t_questionnaireID);
            this.Controls.Add(this.label1);
            this.Name = "UserStartPage";
            this.Text = "UserStartPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserStartPage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.TextBox t_questionnaireID;
    }
}