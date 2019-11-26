using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SelectButton;

namespace Questionnaire.UserPages
{
    public partial class AnswerQuestions : Form
    {
        questionDBTableAdapters.questionsTableAdapter questionsTable = new questionDBTableAdapters.questionsTableAdapter();
        questionDBTableAdapters.optionsTableAdapter optionsTable = new questionDBTableAdapters.optionsTableAdapter();
        questionDBTableAdapters.UserAnswerTableAdapter UserAnswerTable = new questionDBTableAdapters.UserAnswerTableAdapter();
        questionDB.questionsDataTable questions;
        questionDB.optionsDataTable options;
        public int questionnaireID,QuestionNumber,questionID;
        public int[] answers;
        SButton sButton = new SButton();
        public AnswerQuestions(int questionnaireID,int QuestionNumber)
        {
            InitializeComponent();
            this.questionnaireID = questionnaireID;
            this.QuestionNumber = QuestionNumber;
            StartPosition = FormStartPosition.CenterScreen;
            JudgeJump();
            Init();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            int optionID = sButton.SelectedRadioIndex;
            
            if(sButton.SelectedRadioIndex == 0)
            {
                if (sButton.SelectedCheckbox.Count == 0)
                {
                    MessageBox.Show("请选择选项！");
                    return;
                }
                string msg = "";
                for (int j = 0; j < sButton.SelectedCheckbox.Count; j++)
                {
                    msg += $"{sButton.SelectedCheckbox[j]}";
                }
                optionID = int.Parse(msg);
            }
            answers = new int[] { questionID, optionID };
            //AnswerQuestionCollection.AnswerList.Remove(new int[] { questionID, optionID }) ;
            //AnswerQuestionCollection.AnswerList.Add(new int[] { questionID, optionID });//保存问题ID 和 选项“序号”
            this.Hide();
            AnswerQuestionCollection.answerQuestionList[++AnswerQuestionCollection.QuetionNumber].Show();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            AnswerQuestionCollection.answerQuestionList[--AnswerQuestionCollection.QuetionNumber].Show();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int optionID = sButton.SelectedRadioIndex;

            if (sButton.SelectedRadioIndex == 0)
            {
                string msg = "";
                for (int j = 0; j < sButton.SelectedCheckbox.Count; j++)
                {
                    msg += $"{sButton.SelectedCheckbox[j]}";
                }
                optionID = int.Parse(msg);
            }
            answers = new int[] { questionID, optionID };
            //AnswerQuestionCollection.AnswerList.Add(new int[] { questionID, sButton.SelectedRadioIndex });//保存问题ID 和 选项“序号”
            Submit();
        }

        private void Init()
        {
            questions = questionsTable.GetDataByID(questionnaireID);

            l_questionIntroduce.Text = $"{AnswerQuestionCollection.QuetionNumber + 1}、" + questions.Rows[QuestionNumber][2].ToString();
            questionID = int.Parse(questions.Rows[QuestionNumber][0].ToString());
            options = optionsTable.GetData(questionID); // arg：question ID

            //33, 99
            
            sButton.Init(options, int.Parse(questions.Rows[QuestionNumber][4].ToString()));
            sButton.Location = new Point(33,89);
            
            this.Controls.Add(sButton);
        }

        private void AnswerQuestions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("确定退出？退出后您所做的改变将不会保留！", "确定退出？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                AnswerQuestionCollection.Dispose();
            }
        }

        /// <summary>
        /// 设置按钮是否可以点击
        /// </summary>
        private void JudgeJump()
        {
            btn_Submit.Enabled = false;
            if (1 + QuestionNumber >= AnswerQuestionCollection.QuestionsCount)
            {
                btn_Next.Enabled = false;
                btn_Submit.Enabled = true;
            }
            if (QuestionNumber - 1 < 0)
            {
                btn_Previous.Enabled = false;
            }
        }

        /// <summary>
        /// 提交问卷
        /// </summary>
        private void Submit()
        {
            try
            {
                for (int i = 0; i < AnswerQuestionCollection.answerQuestionList.Count; i++)
                {
                    if (AnswerQuestionCollection.answerQuestionList[i].answers[1] > 4)//多选内容
                    {
                        string astr = AnswerQuestionCollection.answerQuestionList[i].answers[1].ToString();
                        for (int j = 0; j < astr.Length; j++)
                        {
                            UserAnswerTable.InsertQuery(LoggedInfo.ID, AnswerQuestionCollection.QuestionnaireID, AnswerQuestionCollection.answerQuestionList[i].answers[0], astr[j].ToString(), DateTime.Now);
                        }
                    }
                    else
                    {
                        UserAnswerTable.InsertQuery(LoggedInfo.ID, AnswerQuestionCollection.QuestionnaireID, AnswerQuestionCollection.answerQuestionList[i].answers[0], AnswerQuestionCollection.answerQuestionList[i].answers[1].ToString(), DateTime.Now);
                    }
                }
                #region old
                /*for (int i = 0; i < AnswerQuestionCollection.AnswerList.Count; i++)
                {
                    if (AnswerQuestionCollection.AnswerList[i][1] > 4)//多选内容
                    {
                        string astr = AnswerQuestionCollection.AnswerList[i][1].ToString();
                        for (int j = 0; j < astr.Length; j++)
                        {
                            UserAnswerTable.InsertQuery(LoggedInfo.ID, AnswerQuestionCollection.QuestionnaireID, AnswerQuestionCollection.AnswerList[i][0], astr[j].ToString(), DateTime.Now);
                        }
                    }
                    else
                    {
                        UserAnswerTable.InsertQuery(LoggedInfo.ID, AnswerQuestionCollection.QuestionnaireID, AnswerQuestionCollection.AnswerList[i][0], AnswerQuestionCollection.AnswerList[i][1].ToString(), DateTime.Now);
                    }
                }*/
                #endregion
                MessageBox.Show("提交成功！");
                AnswerQuestionCollection.Dispose();
            }
            catch
            {
                MessageBox.Show("提交失败");
            }
        }
    }
}
