using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            questionDB.AccountDataTable accountRows = new questionDBTableAdapters.AccountTableAdapter().GetData();
            foreach (var v in accountRows)
            {
                if (v.name == t_Name.Text && v.password == t_Password.Text)
                {

                    //保存登录信息
                    LoggedInfo.ID = v.id;
                    LoggedInfo.Name = v.name;
                    LoggedInfo.Pwd = v.password;
                    LoggedInfo.Identity = v.identify;

                    this.Hide();

                    if (v.identify == 0)//admin
                    {
                        adminPages.AddQuestionnaire addQuestionnaire = new adminPages.AddQuestionnaire(this);
                        addQuestionnaire.ShowDialog();
                    }
                    else    //root
                    {
                        UserPages.UserStartPage userStartPage = new UserPages.UserStartPage(this);
                        userStartPage.ShowDialog();
                    }
                    return;
                }
            }
            MessageBox.Show("账号或密码错误");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
