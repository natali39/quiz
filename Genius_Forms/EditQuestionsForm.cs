using Genius.Common;
using System;
using System.Windows.Forms;

namespace Genius_Forms
{
    public partial class EditQuestionsForm : Form
    {
        public EditQuestionsForm()
        {
            InitializeComponent();
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            var questionFormated = $"{addQuestionTextBox.Text};{addAnswerTextBox.Text}{Environment.NewLine}";
            FileProvider.Save(FilesPath.QuestionsFile, questionFormated, true);
            addQuestionTextBox.Text = String.Empty;
            addAnswerTextBox.Text = String.Empty;
        }

    }
}
