namespace RestaurantRaterAPI.Models
{
    public class RatingEdit
    {
        public float FoodScore {get; set; }
        public float CleanlinessScore {get; set; }
        public float AtmosphereScore {get; set; }
        public int RestaurantId { get; set; }
    }
}