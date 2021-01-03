using Genius.Common;
using System;
using System.Windows.Forms;


namespace Genius_Forms
{
    public partial class MainForm : Form
    {
        private User user;
        private Game game;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void ShowCurrentQuestion()
        {
            сurrentQuestionNumberLabel.Text = game.GetCurrentQuestionTitle();
            сurrentQuestionLabel.Text = game.PopCurrentQuestion();
            userInputTextBox.Text = String.Empty;
            userInputTextBox.Focus();
        }

        private void NewGame()
        {
            UserNameInputForm nameForm = new UserNameInputForm();
            nameForm.ShowDialog();
            user = new User(nameForm.UserName);
            game = new Game(user);
            game.OnEndGame += OnEndGame;
            ShowCurrentQuestion();
            nextQuestionButton.Enabled = true;
            welcomeMessageLabel.Text = $"Привет, { user.Name}!\nОтвечай на вопросы викторины и узнай свой диагноз!";
        }

        private void OnEndGame(object sender, EventArgs e)
        {
            var diagnose = game.GetUserDiagnose();
            MessageBox.Show(diagnose, "Результаты викторины:");
            nextQuestionButton.Enabled = false;
            welcomeMessageLabel.Text = $"{user.Name}, эта игра окончена! Можешь начать заново!";
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            var userAnswer = userInputTextBox.Text;
            game.AcceptUserAnswer(userAnswer);
            if (!game.IsEnd)
            {
                ShowCurrentQuestion();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var diagnosesForm = new UsersDiagnosesListForm();
            diagnosesForm.Show();
        }

        private void добавитьВопросыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditQuestionsForm editQuestionsForm = new EditQuestionsForm();
            editQuestionsForm.ShowDialog();
        }
    }
}
