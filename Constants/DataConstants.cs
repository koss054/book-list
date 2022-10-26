namespace BookList.Constants
{
    public class DataConstants
    {
        public class Book
        {
            public const int MinBookTitleLength = 5;
            public const int MaxBookTitleLength = 100;

            public const int MinDescriptionLength = 5;
            public const int MaxDescriptionLength = 5000;

            public const int MinAuthorLength = 5;
            public const int MaxAuthorLength = 50;

            public const string MinRatingValue = "0.00";
            public const string MaxRatingValue = "5.00";
        }

        public class Genre
        {
            public const int MinNameLength = 5;
            public const int MaxNameLength = 50;
        }

        public class User
        {
            public const int MinUserNameLength = 5;
            public const int MaxUserNameLength = 20;

            public const int MinEmailLength = 5;
            public const int MaxEmailLength = 60;

            public const int MinPasswordLength = 12;
            public const int MaxPasswordLength = 32;
        }
    }
}
