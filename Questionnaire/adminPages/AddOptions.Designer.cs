namespace Questionnaire.adminPages
{
    partial class AddOptions
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
            this.dgv_option = new System.Windows.Forms.DataGridView();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.t_OptionIntroduce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_No = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_No)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16F);
            this.label4.Location = new System.Drawing.Point(446, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "Option";
            // 
            // dgv_option
            // 
            this.dgv_option.AllowUserToAddRows = false;
            this.dgv_option.AllowUserToDeleteRows = false;
            this.dgv_option.AllowUserToResizeColumns = false;
            this.dgv_option.AllowUserToResizeRows = false;
            this.dgv_option.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_option.Location = new System.Drawing.Point(7, 106);
            this.dgv_option.Name = "dgv_option";
            this.dgv_option.ReadOnly = true;
            this.dgv_option.RowTemplate.Height = 23;
            this.dgv_option.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_option.Size = new System.Drawing.Size(976, 339);
            this.dgv_option.TabIndex = 30;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(903, 56);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 38);
            this.btn_Del.TabIndex = 27;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(822, 56);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 38);
            this.btn_Save.TabIndex = 28;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(741, 55);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 38);
            this.btn_Add.TabIndex = 29;
            this.btn_Add.Text = "添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "Option:";
            // 
            // t_OptionIntroduce
            // 
            this.t_OptionIntroduce.Location = new System.Drawing.Point(82, 79);
            this.t_OptionIntroduce.Name = "t_OptionIntroduce";
            this.t_OptionIntroduce.Size = new System.Drawing.Size(635, 21);
            this.t_OptionIntroduce.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "问题Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "序号：";
            // 
            // num_No
            // 
            this.num_No.Location = new System.Drawing.Point(184, 50);
            this.num_No.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.num_No.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_No.Name = "num_No";
            this.num_No.Size = new System.Drawing.Size(120, 21);
            this.num_No.TabIndex = 33;
            this.num_No.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 455);
            this.Controls.Add(this.num_No);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_option);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_OptionIntroduce);
            this.Name = "AddOptions";
            this.Text = "AddOptions";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_No)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_option;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_OptionIntroduce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_No;
    }
}