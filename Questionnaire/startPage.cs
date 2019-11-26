using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Questionnaire;
using Questionnaire.questionDBTableAdapters;

namespace Questionnaire
{
    public partial class startPage : Form
    {
        public startPage()
        {
            InitializeComponent();

            questionDB.AccountDataTable accounts = new AccountTableAdapter().GetData();


        }
    }
}
