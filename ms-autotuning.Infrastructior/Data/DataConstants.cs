namespace ms_autotuning.Infrastructior.Data
{
    public static class DataConstants
    {
        public static class AdministratorConstants
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 2;

            public const int PhoneNumberMaxLength = 15;
        }

        public static class MechanicConstants
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 2;

            public const int PhoneNumberMaxLength = 15;
            public const int PhoneNumberMinLength = 15;
        }

        public static class PromotionConstants
        {
            public const int DescriptionMaxLength = 1000;

        }

        public static class ReservationConstants
        {
            public const int DescriptionMaxLength = 1000;
            public const int PhoneNumber = 15;
            public const int PhoneNumberMinLength = 3;
        }


        public static class ReviewConstants
        {
            public const int Feedback = 1000;

            public const int RatingMax = 5;
            public const int RatingMin = 0;
        }

        public static class ServiceConstants
        {
            public const int NameMaxLength = 150;
            public const int NameMinLength = 2;

            public const int DescriptionMaxLength = 1500;
            public const int DescriptionMinLength = 10;
        }

        public static class OrderConstants
        {
            public const int DescriptionMaxLength = 1000;
            public const int PhoneNumber = 15;
        }

        public static class ApplicationUserConstants
        {
            public const int FirstNameMaxLength = 100;
            public const int FirstNameMinLength = 2;

            public const int LastNameMaxLength = 100;
            public const int LastNameMinLength = 2;
        }

        public static class ApplicationApplicationRole
        {
            public const int BGNameMaxLength = 100;
            public const int BGNameMinLength = 2;
        }

    }
}
