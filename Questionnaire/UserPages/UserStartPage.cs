using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire.UserPages
{
    public partial class UserStartPage : Form
    {
        Form form;

        questionDBTableAdapters.questionnaireTableAdapter questionnaireTable = new questionDBTableAdapters.questionnaireTableAdapter();
        public UserStartPage(Form aform)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            form = aform;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(t_questionnaireID.Text)) {
                MessageBox.Show("请输入问卷ID");
                return;
            }
            int id = int.Parse(t_questionnaireID.Text);
            questionDB.questionnaireDataTable questionnaires = questionnaireTable.GetDataByID(id);
            if (questionnaires.Count<=0)
            {
                MessageBox.Show("该问卷不存在！");
                return;
            }
            AnswerQuestionnaire answerQuestionnaire = new AnswerQuestionnaire(id, questionnaires) ;
            answerQuestionnaire.ShowDialog();
        }

        private void t_questionnaireID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void UserStartPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
