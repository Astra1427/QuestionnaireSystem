using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire.adminPages
{
    public partial class AddOptions : Form
    {
        questionDBTableAdapters.optionsTableAdapter optionsTable = new questionDBTableAdapters.optionsTableAdapter();
        int questionID, SelectedOptionID;
        public AddOptions(int questionID)
        {
            InitializeComponent();
            this.questionID = questionID;
            StartPosition = FormStartPosition.CenterScreen;
            Init();
        }

        private void Init()
        {
            dgv_option.MultiSelect = false;
            dgv_option.DataSource = optionsTable.GetData(questionID);
            dgv_option.Columns[0].HeaderText = "ID";
            dgv_option.Columns[1].HeaderText = "选项序号";
            dgv_option.Columns[2].HeaderText = "选项描述";
            dgv_option.Columns[3].HeaderText = "创建时间";
            dgv_option.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
            dgv_option.CellClick += dgv_CellClick;

            //隔行换色
            dgv_option.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgv_option.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(t_OptionIntroduce.Text))
            {
                MessageBox.Show("选项描述不能为空!");
                return;
            }
            for (int i = 0; i < dgv_option.RowCount;i++)
            {
                if (num_No.Value == (int)dgv_option.Rows[i].Cells[1].Value)
                {
                    MessageBox.Show("已有相同序号的选项");
                    return;
                }
            }
            int changeRows = optionsTable.InsertQuery(questionID, (int)num_No.Value, t_OptionIntroduce.Text,5,DateTime.Now);
            if (changeRows > 0)
            {
                MessageBox.Show("添加成功");
                dgv_option.DataSource = optionsTable.GetData(questionID);
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex < 0)
            {
                return;
            }
            SelectedOptionID = int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.t_OptionIntroduce.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.num_No.Value = int.Parse(dgv.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (SelectedOptionID < 0)
            {
                MessageBox.Show("请选择问题");
                return;
            }
            int ChangeRows = optionsTable.UpdateQuery((int)num_No.Value, t_OptionIntroduce.Text, 4,SelectedOptionID);

            if (ChangeRows > 0)
            {
                MessageBox.Show("修改成功");
                dgv_option.DataSource = optionsTable.GetData(questionID);
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (SelectedOptionID < 0)
            {
                MessageBox.Show("请选择问题");
                return;
            }
            if (MessageBox.Show("确定删除该问题？", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int ChangeRows = optionsTable.DeleteQuery(SelectedOptionID);

                if (ChangeRows > 0)
                {
                    MessageBox.Show("删除成功");
                    dgv_option.DataSource = optionsTable.GetData(questionID);
                }
                else
                {
                    MessageBox.Show("删除成功");
                }
            }
        }
    }
}
