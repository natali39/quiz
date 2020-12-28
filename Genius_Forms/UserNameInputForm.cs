using System;
using System.Windows.Forms;

namespace Genius_Forms
{
    public partial class UserNameInputForm : Form
    {
        public string UserName { get; private set; }

        public UserNameInputForm()
        {
            InitializeComponent();
        }

        private void userNameAcceptButton_Click(object sender, EventArgs e)
        {
            string userInput = userNameTextBox.Text;
            SetUserName(userInput);
        }

        private void UserNameInputForm_Shown(object sender, EventArgs e)
        {
            userNameTextBox.Focus();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            userNameAcceptButton.Enabled = true;
        }

        private void SetUserName(string userInput)
        {
            if (userInput == String.Empty)
            {
                MessageBox.Show("Введите своё имя!");
                userNameAcceptButton.Enabled = false;
            }
            else
            {
                UserName = userInput;
                this.Close();
            }
        }
    }
}
