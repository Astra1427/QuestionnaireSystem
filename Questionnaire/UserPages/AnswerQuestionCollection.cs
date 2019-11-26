using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire.UserPages
{
    class AnswerQuestionCollection
    {
        public static List<AnswerQuestions> answerQuestionList = new List<AnswerQuestions>();

        questionDB.questionsDataTable questions;
        /// <summary>
        /// 当前问题序号
        /// </summary>
        public static int QuetionNumber;
        /// <summary>
        /// 保存问题ID 和 选项“序号”
        /// </summary>
        public static List<int[]> AnswerList = new List<int[]>();
        /// <summary>
        /// 当前问卷ID
        /// </summary>
        public static int QuestionnaireID ;
        public static int QuestionsCount;
        static Form form;
        public AnswerQuestionCollection(int id,Form aform)
        {
            form = aform;
            QuetionNumber = 0;
            questions = new questionDBTableAdapters.questionsTableAdapter().GetDataByID(id);
            QuestionnaireID = id;
            QuestionsCount = questions.Count;
            for (int i = 0; i < questions.Count; i++)
            {
                answerQuestionList.Add(new AnswerQuestions(id, i));
            }
        }
        public static void Dispose()
        {
            for (int i = 0; i < answerQuestionList.Count; i++)
            {
                answerQuestionList[i].Dispose();
            }
            answerQuestionList.Clear();
            AnswerList.Clear();
            form.Close();
        }
    }
}
