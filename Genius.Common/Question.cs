using System;
using System.Collections.Generic;
using System.IO;

namespace Genius.Common
{
    public class Question
    {
        public string Text;
        public string Answer;

        public Question(string text, string answer)
        {
            this.Text = text;
            this.Answer = answer;
        }

        public static List<Question> GetQuestions()
        {
            List<Question> questions = new List<Question>();
            questions.Add(new Question("Сколько будет два плюс два умноженное на два?", "6"));
            questions.Add(new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", "9"));
            questions.Add(new Question("На двух руках 10 пальцев сколько пальцев на 5 руках ?", "25"));
            questions.Add(new Question("Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?", "60"));
            questions.Add(new Question("Пять свечей горело, две  потухли. Сколько свечей  осталось?", "2"));
            questions.Add(new Question("5 станков за 5 минут производят 5 деталей. За сколько минут 100 станков произведут 100 деталей?", "5"));
            return questions;
        }

        internal static List<Question> GetQuestionsFromFile()
        {
            var questionsFormated = FileProvider.GetValue(FilesPath.QuestionsFile);
            var questionsFormatedLines = questionsFormated.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            var questions = new List<Question>(questionsFormatedLines.Length);
            foreach (var line in questionsFormatedLines)
            {
                var splitLine = line.Split(';');
                var question = new Question(splitLine[0], splitLine[1]);
                questions.Add(question);
            }
            return questions;
        }

        public static void InitQuestions()
        {
            if (!FileProvider.IsExist(FilesPath.QuestionsFile))
            {
                var questionsFormated = GetQuestionsFormated(GetQuestions());
                FileProvider.Save(FilesPath.QuestionsFile, questionsFormated);
            }
        }

        private static string GetQuestionsFormated(List<Question> questions)
        {
            var questionsFormated = string.Empty;
            foreach (var question in questions)
            {
                questionsFormated += $"{question.Text};{question.Answer}{Environment.NewLine}";
            }
            return questionsFormated;
        }

    }
}
