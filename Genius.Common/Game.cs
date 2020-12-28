using System;
using System.Collections.Generic;
using System.IO;

namespace Genius.Common
{
    public class Game
    {
        private User user;
        private List<Question> questions;
        private int currentQuestionNumber = 1;
        private Question currentQuestion;

        public int CountQuestions { get; private set; }

        public event EventHandler OnEndGame;

        public bool IsEnd
        {
            get
            {
                return currentQuestionNumber > CountQuestions;
            }
        }

        public Game(User user)
        {
            this.user = user;
            InitGame();

            questions = Question.GetQuestionsFromFile();
            CountQuestions = questions.Count;
        }

        private void InitGame()
        {
            Question.InitQuestions();
            Diagnose.InitUsersDiagnoses();
        }

        public string GetCurrentQuestionTitle()
        {
            return "Вопрос №: " + currentQuestionNumber;
        }

        public string PopCurrentQuestion()
        {
            Random random = new Random();
            var indexRandomQuestion = random.Next(0, questions.Count);
            currentQuestion = questions[indexRandomQuestion];
            questions.RemoveAt(indexRandomQuestion);
            return currentQuestion.Text;
        }

        public void AcceptUserAnswer(string userAnswer)
        {
            if (userAnswer == currentQuestion.Answer)
            {
                user.AddRightAnswer();
            }

            currentQuestionNumber++;

            if (IsEnd)
            {
                if (OnEndGame != null)
                {
                    OnEndGame.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public string GetUserDiagnose()
        {
            var diagnose = Diagnose.CalculateDiagnose(user, CountQuestions);
            
            var value = $"{user.Name};{user.CountRightAnswers};{diagnose}{Environment.NewLine}";
            FileProvider.Save(FilesPath.UsersDiagnosesFile, value, append: true);

            var formatedDiagnose = Diagnose.GetFormatedDiagnose(user, diagnose);
            return $"{formatedDiagnose} из {CountQuestions}";
        }
    }
}
