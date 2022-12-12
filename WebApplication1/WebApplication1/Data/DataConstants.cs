namespace QuizSystem.Data
{
    public class DataConstants
    {
        public class Answer
        {
            public const int TitleMinLength = 1;
            public const int TitleMaxLength = 30;
        }

        public class Question
        {
            public const int TitleMinLength = 10;
            public const int TitleMaxLength = 50;
        }

        public class Quiz
        {
            public const int TitleMinLength = 5;
            public const int TitleMaxLength = 30;
        }

        public class Category
        {
            public const int TitleMinLength = 3;
            public const int TitleMaxLength = 20;
        }

        public class User
        {
            public const int FirstNameMinLength = 3;
            public const int FirstNameMaxLength = 15;
            public const int LastNameMinLength = 6;
            public const int LastNameMaxLength = 30;
        }
    }
}
