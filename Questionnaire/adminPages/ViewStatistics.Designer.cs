namespace Questionnaire.adminPages
{
    partial class ViewStatistics
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
            this.dgv_Statistics = new System.Windows.Forms.DataGridView();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Statistics)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16F);
            this.label4.Location = new System.Drawing.Point(446, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "ViewStatistics";
            // 
            // dgv_Statistics
            // 
            this.dgv_Statistics.AllowUserToAddRows = false;
            this.dgv_Statistics.AllowUserToDeleteRows = false;
            this.dgv_Statistics.AllowUserToResizeColumns = false;
            this.dgv_Statistics.AllowUserToResizeRows = false;
            this.dgv_Statistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Statistics.Location = new System.Drawing.Point(7, 100);
            this.dgv_Statistics.Name = "dgv_Statistics";
            this.dgv_Statistics.ReadOnly = true;
            this.dgv_Statistics.RowTemplate.Height = 23;
            this.dgv_Statistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Statistics.Size = new System.Drawing.Size(976, 345);
            this.dgv_Statistics.TabIndex = 30;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(283, 56);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 38);
            this.btn_Del.TabIndex = 27;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(144, 56);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 38);
            this.btn_Save.TabIndex = 28;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 56);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 38);
            this.btn_Add.TabIndex = 29;
            this.btn_Add.Text = "柱状图";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // ViewStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 455);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_Statistics);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Add);
            this.Name = "ViewStatistics";
            this.Text = "ViewStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Statistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Statistics;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Add;
    }
}