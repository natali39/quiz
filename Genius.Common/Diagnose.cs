using System;
using System.Collections.Generic;

namespace Genius.Common
{
    public class Diagnose
    {
        private static List<string> GetDiagnoses()
        {
            List<string> diagnoses = new List<string>
            {
                "Идиот",
                "Кретин",
                "Дурак",
                "Нормальный",
                "Талант",
                "Гений"
            };
            return diagnoses;
        }

        public static void InitUsersDiagnoses()
        {
            if (!FileProvider.IsExist(FilesPath.UsersDiagnosesFile))
            {
                FileProvider.Create(FilesPath.UsersDiagnosesFile);
            }
        }

        public static string CalculateDiagnose(User user, int countQuestions)
        {
            var diagnoses = GetDiagnoses();
            var percentOfCorrectAnswers = Math.Round(((double)user.CountRightAnswers / countQuestions) * 100);

            if (percentOfCorrectAnswers >= 90)
            {
                return diagnoses[5];
            }
            if (percentOfCorrectAnswers >= 70 && percentOfCorrectAnswers < 90)
            {
                return diagnoses[4];
            }
            if (percentOfCorrectAnswers >= 50 && percentOfCorrectAnswers < 70)
            {
                return diagnoses[3];
            }
            if (percentOfCorrectAnswers >= 30 && percentOfCorrectAnswers < 50)
            {
                return diagnoses[2];
            }
            if (percentOfCorrectAnswers >= 10 && percentOfCorrectAnswers < 30)
            {
                return diagnoses[1];
            }
            if (percentOfCorrectAnswers >= 00 && percentOfCorrectAnswers < 10)
            {
                return diagnoses[0];
            }
            else
            {
                return $"Диагноз не вычислен!";
            }
       }

        public static string GetFormatedDiagnose(User user, string diagnose)
        {
            return $"{user.Name}: диагноз - {diagnose}, количество правильных ответов - {user.CountRightAnswers}";
        }
    }
}
