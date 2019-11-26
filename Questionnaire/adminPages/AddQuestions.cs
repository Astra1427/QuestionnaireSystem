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
    public partial class AddQuestions : Form
    {
        questionDBTableAdapters.questionsTableAdapter questionsTable = new questionDBTableAdapters.questionsTableAdapter();
        int questionnaireID, SelectedQuestionID;
        public AddQuestions(int questionnaireID)
        {
            InitializeComponent();
            this.questionnaireID = questionnaireID;
            StartPosition = FormStartPosition.CenterScreen;
            Init();
        }

        private void Init()
        {
            c_IsRequire.SelectedIndex = 1;
            c_QuestionClass.SelectedIndex = 0;


            dgv_question.MultiSelect = false;
            dgv_question.DataSource = questionsTable.GetData(questionnaireID);
            dgv_question.Columns[0].HeaderText = "ID";
            dgv_question.Columns[1].HeaderText = "创建人ID";
            dgv_question.Columns[2].HeaderText = "问题";
            dgv_question.Columns[3].HeaderText = "创建时间";
            dgv_question.Columns[4].HeaderText = "问题类型";
            dgv_question.Columns[5].HeaderText = "是否必答";
            dgv_question.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            dgv_question.CellClick += dgv_CellClick;

            //隔行换色
            dgv_question.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgv_question.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            dtp_CreateDate.Value = DateTime.Now;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(t_QuestionIntroduce.Text))
            {
                MessageBox.Show("问题不能为空!");
                return;
            }

            int changeRows = questionsTable.InsertQuery(questionnaireID,t_QuestionIntroduce.Text,c_QuestionClass.SelectedIndex,c_IsRequire.SelectedIndex,DateTime.Now);
            if (changeRows > 0)
            {
                MessageBox.Show("添加成功");
                dgv_question.DataSource = questionsTable.GetData(questionnaireID);
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (SelectedQuestionID < 0)
            {
                MessageBox.Show("请选择问题");
                return;
            }
            int ChangeRows = questionsTable.UpdateQuery(t_QuestionIntroduce.Text,c_QuestionClass.SelectedIndex,c_IsRequire.SelectedIndex,SelectedQuestionID);

            if (ChangeRows > 0)
            {
                MessageBox.Show("修改成功");
                dgv_question.DataSource = questionsTable.GetData(questionnaireID);
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (SelectedQuestionID < 0)
            {
                MessageBox.Show("请选择问题");
                return;
            }
            if (MessageBox.Show("确定删除该问题？", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int ChangeRows = questionsTable.DeleteQuery(SelectedQuestionID);

                if (ChangeRows > 0)
                {
                    MessageBox.Show("删除成功");
                    dgv_question.DataSource = questionsTable.GetData(questionnaireID);
                }
                else
                {
                    MessageBox.Show("删除成功");
                }
            }
        }

        private void dgv_question_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddOptions addOptions = new AddOptions(int.Parse((sender as DataGridView).Rows[e.RowIndex].Cells[0].Value.ToString()));
            addOptions.ShowDialog();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex < 0)
            {
                return;
            }
            this.t_QuestionIntroduce.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.c_QuestionClass.SelectedItem = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.c_IsRequire.SelectedItem = dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.dtp_CreateDate.Value = DateTime.Parse(dgv.Rows[e.RowIndex].Cells[3].Value.ToString());
            SelectedQuestionID = int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
