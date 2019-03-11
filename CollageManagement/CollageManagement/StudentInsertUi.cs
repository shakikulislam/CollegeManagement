using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollageManagement.BLL;
using CollageManagement.Models;

namespace CollageManagement
{
    public partial class StudentInsertUi : Form
    {
        public StudentInsertUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Student aStudent=new Student(Convert.ToInt32(idTextBox.Text),nameTextBox.Text,Convert.ToInt32(sessionTextBox.Text));

                StudentBll studentBll=new StudentBll();
                bool isSuccess = studentBll.Add(aStudent);
                if (isSuccess)
                {
                    MessageBox.Show("Saved");
                    foreach (Control textBoxControl in Controls)
                    {
                        if (textBoxControl is TextBox)
                        {
                            textBoxControl.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Message Not Saved");
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
