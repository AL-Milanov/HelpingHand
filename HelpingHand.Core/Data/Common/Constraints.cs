namespace HelpingHand.Core.Data.Common
{
    public static class Constraints
    {
        // ID string length
        public const int ID_GUID_LENGTH = 36;

        // City constraints

        public const int CITY_NAME_MIN_LENGTH = 1;
        public const int CITY_NAME_MAX_LENGTH = 85;

        // Clothes constraints

        public const int CLOTHES_TYPE_MIN_LENGTH = 3;
        public const int CLOTHES_TYPE_MAX_LENGTH = 20;

        public const int CLOTHES_SIZE_MIN_LENGTH = 1;
        public const int CLOTHES_SIZE_MAX_LENGTH = 8;

        // Country constraints

        public const int COUNTRY_NAME_MIN_LENGTH = 4;
        public const int COUNTRY_NAME_MAX_LENGTH = 56;

        // Food constraints

        public const int FOOD_NAME_MIN_LENGTH = 3;
        public const int FOOD_NAME_MAX_LENGTH = 25;

        public const int FOOD_QUANTITY_MIN_VALUE = 1;
        public const int FOOD_QUANTITY_MAX_VALUE = 250;

        // Shelter constraints

        public const int SHELTER_ADDRESS_MIN_LENGTH = 8;
        public const int SHELTER_ADDRESS_MAX_LENGTH = 80;

        public const int SHELTER_CAPACITY_MIN_VALUE = 1;
        public const int SHELTER_CAPACITY_MAX_VALUE = 20;

        public const int SHELTER_AREA_MIN_VALUE = 5;
        public const int SHELTER_AREA_MAX_VALUE = byte.MaxValue;
    }
}
