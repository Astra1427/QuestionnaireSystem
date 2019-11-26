namespace Questionnaire.UserPages
{
    partial class AnswerQuestions
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
            this.l_questionIntroduce = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_questionIntroduce
            // 
            this.l_questionIntroduce.AutoSize = true;
            this.l_questionIntroduce.Font = new System.Drawing.Font("宋体", 14F);
            this.l_questionIntroduce.Location = new System.Drawing.Point(31, 20);
            this.l_questionIntroduce.Name = "l_questionIntroduce";
            this.l_questionIntroduce.Size = new System.Drawing.Size(99, 19);
            this.l_questionIntroduce.TabIndex = 0;
            this.l_questionIntroduce.Text = "questions";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(580, 251);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(86, 34);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "下一个";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(686, 251);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(86, 34);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(499, 251);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(75, 34);
            this.btn_Previous.TabIndex = 2;
            this.btn_Previous.Text = "上一个";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // AnswerQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 297);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.l_questionIntroduce);
            this.Name = "AnswerQuestions";
            this.Text = "AnswerQuestions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnswerQuestions_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_questionIntroduce;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Previous;
    }
}