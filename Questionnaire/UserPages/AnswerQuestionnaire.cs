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
    public partial class AnswerQuestionnaire : Form
    {
        int questionnaireID;
        questionDB.questionnaireDataTable questionnairesDataTable;
        DateTime EndTime;
        public AnswerQuestionnaire(int questionnaireID,questionDB.questionnaireDataTable questionnaires)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.questionnaireID = questionnaireID;
            questionnairesDataTable = questionnaires;
            Init();
        }

        private void Init()
        {
            EndTime = DateTime.Parse(questionnairesDataTable.Rows[0][5].ToString());

            l_QuestionnaireName.Text = questionnairesDataTable.Rows[0][2].ToString();
            l_Introduce.Text = questionnairesDataTable.Rows[0][3].ToString();
            l_StartDate.Text = DateTime.Parse(questionnairesDataTable.Rows[0][4].ToString()).ToString();
            l_EndDate.Text = EndTime.ToString();

            AnswerQuestionCollection answerQuestion = new AnswerQuestionCollection(questionnaireID, this);
            l_QuestionCount.Text = $"{AnswerQuestionCollection.QuestionsCount}个问题";
        }

        questionDBTableAdapters.UserAnswerTableAdapter UserAnswerTableAdapter = new questionDBTableAdapters.UserAnswerTableAdapter();
        private void btn_Answer_Click(object sender, EventArgs e)
        {
            if (EndTime < DateTime.Now)
            {
                MessageBox.Show("问卷回答时间已过！");
                return;
            }
            if (UserAnswerTableAdapter.ScalarQuery(LoggedInfo.ID,questionnaireID) >0)
            {
                MessageBox.Show("您已完成该问卷，无需重复完成！");
                return;
            }
            //AnswerQuestions answerQuestions = new AnswerQuestions(questionnaireID,0);
            //answerQuestions.Show();
            //if (AnswerQuestionCollection.answerQuestionList==null) { AnswerQuestionCollection.answerQuestionList = new List<AnswerQuestions>(); }
            AnswerQuestionCollection.answerQuestionList[0].Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
