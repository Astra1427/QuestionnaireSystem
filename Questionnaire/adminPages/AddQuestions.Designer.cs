namespace Questionnaire.adminPages
{
    partial class AddQuestions
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
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_question = new System.Windows.Forms.DataGridView();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_QuestionIntroduce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c_QuestionClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.c_IsRequire = new System.Windows.Forms.ComboBox();
            this.dtp_CreateDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_question)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16F);
            this.label4.Location = new System.Drawing.Point(446, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Question";
            // 
            // dgv_question
            // 
            this.dgv_question.AllowUserToAddRows = false;
            this.dgv_question.AllowUserToDeleteRows = false;
            this.dgv_question.AllowUserToResizeColumns = false;
            this.dgv_question.AllowUserToResizeRows = false;
            this.dgv_question.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_question.Location = new System.Drawing.Point(7, 105);
            this.dgv_question.Name = "dgv_question";
            this.dgv_question.ReadOnly = true;
            this.dgv_question.RowTemplate.Height = 23;
            this.dgv_question.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_question.Size = new System.Drawing.Size(976, 339);
            this.dgv_question.TabIndex = 18;
            this.dgv_question.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_question_CellDoubleClick);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(903, 55);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 38);
            this.btn_Del.TabIndex = 15;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(822, 55);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 38);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(741, 54);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 38);
            this.btn_Add.TabIndex = 17;
            this.btn_Add.Text = "添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "CreateDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "question:";
            // 
            // t_QuestionIntroduce
            // 
            this.t_QuestionIntroduce.Location = new System.Drawing.Point(82, 78);
            this.t_QuestionIntroduce.Name = "t_QuestionIntroduce";
            this.t_QuestionIntroduce.Size = new System.Drawing.Size(635, 21);
            this.t_QuestionIntroduce.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "问题类型：";
            // 
            // c_QuestionClass
            // 
            this.c_QuestionClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_QuestionClass.FormattingEnabled = true;
            this.c_QuestionClass.Items.AddRange(new object[] {
            "单选",
            "多选"});
            this.c_QuestionClass.Location = new System.Drawing.Point(73, 43);
            this.c_QuestionClass.Name = "c_QuestionClass";
            this.c_QuestionClass.Size = new System.Drawing.Size(121, 20);
            this.c_QuestionClass.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "是否必填：";
            // 
            // c_IsRequire
            // 
            this.c_IsRequire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_IsRequire.FormattingEnabled = true;
            this.c_IsRequire.Items.AddRange(new object[] {
            "否",
            "是"});
            this.c_IsRequire.Location = new System.Drawing.Point(347, 46);
            this.c_IsRequire.Name = "c_IsRequire";
            this.c_IsRequire.Size = new System.Drawing.Size(121, 20);
            this.c_IsRequire.TabIndex = 20;
            // 
            // dtp_CreateDate
            // 
            this.dtp_CreateDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtp_CreateDate.Enabled = false;
            this.dtp_CreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_CreateDate.Location = new System.Drawing.Point(568, 46);
            this.dtp_CreateDate.Name = "dtp_CreateDate";
            this.dtp_CreateDate.ShowUpDown = true;
            this.dtp_CreateDate.Size = new System.Drawing.Size(136, 21);
            this.dtp_CreateDate.TabIndex = 21;
            // 
            // AddQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 455);
            this.Controls.Add(this.dtp_CreateDate);
            this.Controls.Add(this.c_IsRequire);
            this.Controls.Add(this.c_QuestionClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_question);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_QuestionIntroduce);
            this.Name = "AddQuestions";
            this.Text = "AddQuestion";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_question)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_question;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_QuestionIntroduce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox c_QuestionClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox c_IsRequire;
        private System.Windows.Forms.DateTimePicker dtp_CreateDate;
    }
}