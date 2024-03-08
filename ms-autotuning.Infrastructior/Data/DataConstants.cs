namespace ms_autotuning.Infrastructior.Data
{
    public static class DataConstants
    {
        public static class AdministratorConstants
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 2;
        }

        public static class MechanicConstants
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 2;
        }

        public static class PromotionConstants
        {
             public const int DescriptionMaxLength = 1000;
        }

        public static class ReservationConstants
        {
            public const int DescriptionMaxLength = 1000;
            public const int PhoneNumber = 20;

            public const int UserNameMaxLength = 50;
            public const int UserNameMinLength = 2;
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
    }
}
