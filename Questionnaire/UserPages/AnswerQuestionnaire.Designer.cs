namespace Questionnaire.UserPages
{
    partial class AnswerQuestionnaire
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
            this.l_QuestionnaireName = new System.Windows.Forms.Label();
            this.l_Introduce = new System.Windows.Forms.Label();
            this.l_QuestionCount = new System.Windows.Forms.Label();
            this.l_StartDate = new System.Windows.Forms.Label();
            this.l_EndDate = new System.Windows.Forms.Label();
            this.btn_Answer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_QuestionnaireName
            // 
            this.l_QuestionnaireName.AutoSize = true;
            this.l_QuestionnaireName.Font = new System.Drawing.Font("宋体", 18F);
            this.l_QuestionnaireName.Location = new System.Drawing.Point(22, 19);
            this.l_QuestionnaireName.Name = "l_QuestionnaireName";
            this.l_QuestionnaireName.Size = new System.Drawing.Size(214, 24);
            this.l_QuestionnaireName.TabIndex = 0;
            this.l_QuestionnaireName.Text = "questionnaireName";
            // 
            // l_Introduce
            // 
            this.l_Introduce.AutoSize = true;
            this.l_Introduce.Font = new System.Drawing.Font("宋体", 15F);
            this.l_Introduce.Location = new System.Drawing.Point(24, 69);
            this.l_Introduce.Name = "l_Introduce";
            this.l_Introduce.Size = new System.Drawing.Size(99, 20);
            this.l_Introduce.TabIndex = 1;
            this.l_Introduce.Text = "Introduce";
            // 
            // l_QuestionCount
            // 
            this.l_QuestionCount.AutoSize = true;
            this.l_QuestionCount.Location = new System.Drawing.Point(28, 112);
            this.l_QuestionCount.Name = "l_QuestionCount";
            this.l_QuestionCount.Size = new System.Drawing.Size(47, 12);
            this.l_QuestionCount.TabIndex = 2;
            this.l_QuestionCount.Text = "3个问题";
            // 
            // l_StartDate
            // 
            this.l_StartDate.AutoSize = true;
            this.l_StartDate.Location = new System.Drawing.Point(30, 151);
            this.l_StartDate.Name = "l_StartDate";
            this.l_StartDate.Size = new System.Drawing.Size(59, 12);
            this.l_StartDate.TabIndex = 3;
            this.l_StartDate.Text = "startDate";
            // 
            // l_EndDate
            // 
            this.l_EndDate.AutoSize = true;
            this.l_EndDate.Location = new System.Drawing.Point(189, 151);
            this.l_EndDate.Name = "l_EndDate";
            this.l_EndDate.Size = new System.Drawing.Size(47, 12);
            this.l_EndDate.TabIndex = 3;
            this.l_EndDate.Text = "EndDate";
            // 
            // btn_Answer
            // 
            this.btn_Answer.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_Answer.Location = new System.Drawing.Point(371, 119);
            this.btn_Answer.Name = "btn_Answer";
            this.btn_Answer.Size = new System.Drawing.Size(75, 50);
            this.btn_Answer.TabIndex = 4;
            this.btn_Answer.Text = "答题";
            this.btn_Answer.UseVisualStyleBackColor = true;
            this.btn_Answer.Click += new System.EventHandler(this.btn_Answer_Click);
            // 
            // AnswerQuestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 199);
            this.Controls.Add(this.btn_Answer);
            this.Controls.Add(this.l_EndDate);
            this.Controls.Add(this.l_StartDate);
            this.Controls.Add(this.l_QuestionCount);
            this.Controls.Add(this.l_Introduce);
            this.Controls.Add(this.l_QuestionnaireName);
            this.Name = "AnswerQuestionnaire";
            this.Text = "AnswerQuestionnaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_QuestionnaireName;
        private System.Windows.Forms.Label l_Introduce;
        private System.Windows.Forms.Label l_QuestionCount;
        private System.Windows.Forms.Label l_StartDate;
        private System.Windows.Forms.Label l_EndDate;
        private System.Windows.Forms.Button btn_Answer;
    }
}