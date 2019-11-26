namespace Questionnaire.adminPages
{
    partial class AddQuestionnaire
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
            this.t_Name = new System.Windows.Forms.TextBox();
            this.t_Introduce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.dgv_questionnaire = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.t_CreateDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Statistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questionnaire)).BeginInit();
            this.SuspendLayout();
            // 
            // t_Name
            // 
            this.t_Name.Location = new System.Drawing.Point(51, 43);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(100, 21);
            this.t_Name.TabIndex = 0;
            // 
            // t_Introduce
            // 
            this.t_Introduce.Location = new System.Drawing.Point(233, 44);
            this.t_Introduce.Name = "t_Introduce";
            this.t_Introduce.Size = new System.Drawing.Size(100, 21);
            this.t_Introduce.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Introduce";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(804, 32);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(51, 38);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(865, 32);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(51, 38);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(926, 32);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(51, 38);
            this.btn_Del.TabIndex = 4;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // dgv_questionnaire
            // 
            this.dgv_questionnaire.AllowUserToAddRows = false;
            this.dgv_questionnaire.AllowUserToDeleteRows = false;
            this.dgv_questionnaire.AllowUserToResizeColumns = false;
            this.dgv_questionnaire.AllowUserToResizeRows = false;
            this.dgv_questionnaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_questionnaire.Location = new System.Drawing.Point(6, 77);
            this.dgv_questionnaire.Name = "dgv_questionnaire";
            this.dgv_questionnaire.ReadOnly = true;
            this.dgv_questionnaire.RowTemplate.Height = 23;
            this.dgv_questionnaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_questionnaire.Size = new System.Drawing.Size(976, 366);
            this.dgv_questionnaire.TabIndex = 5;
            this.dgv_questionnaire.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_questionnaire_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16F);
            this.label4.Location = new System.Drawing.Point(413, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Questionnaire";
            // 
            // t_CreateDate
            // 
            this.t_CreateDate.Enabled = false;
            this.t_CreateDate.Location = new System.Drawing.Point(417, 43);
            this.t_CreateDate.Name = "t_CreateDate";
            this.t_CreateDate.Size = new System.Drawing.Size(100, 21);
            this.t_CreateDate.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "CreateDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "EndDate";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndDate.Location = new System.Drawing.Point(586, 44);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.ShowUpDown = true;
            this.dtp_EndDate.Size = new System.Drawing.Size(136, 21);
            this.dtp_EndDate.TabIndex = 7;
            // 
            // btn_Statistics
            // 
            this.btn_Statistics.Location = new System.Drawing.Point(743, 32);
            this.btn_Statistics.Name = "btn_Statistics";
            this.btn_Statistics.Size = new System.Drawing.Size(51, 38);
            this.btn_Statistics.TabIndex = 8;
            this.btn_Statistics.Text = "统计";
            this.btn_Statistics.UseVisualStyleBackColor = true;
            this.btn_Statistics.Click += new System.EventHandler(this.btn_Statistics_Click);
            // 
            // AddQuestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 455);
            this.Controls.Add(this.btn_Statistics);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_questionnaire);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_CreateDate);
            this.Controls.Add(this.t_Introduce);
            this.Controls.Add(this.t_Name);
            this.Name = "AddQuestionnaire";
            this.Text = "AddQuestionnaire";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuestionnaire_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questionnaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.TextBox t_Introduce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.DataGridView dgv_questionnaire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_CreateDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Button btn_Statistics;
    }
}