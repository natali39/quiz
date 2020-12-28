using System;

namespace Genius.Common
{
    public class User
    {
        public string Name;
        public int CountRightAnswers { get; private set; }

        private int age;

        public static int Count { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    throw new Exception("Возраст не может быть отрицательным!");
                age = value;
            }
        }

        public User(string name, int age)
        {
            this.Name = name;
            this.CountRightAnswers = 0;
            this.Age = age;
        }

        public User(string name) : this(name, 0)
        {
        }

        public User() : this("Noname")
        {
        }

        public void AddRightAnswer()
        {
            CountRightAnswers++;
        }
    }
}
