namespace WebYugiohCardApplication.Models
{
    public class Card
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string desc { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int level { get; set; }
        public string race { get; set; }
        public string attribute { get; set; }
        public string archetype { get; set; }
        public Card_Sets[] card_sets { get; set; }
        public Card_Images[] card_images { get; set; }
        public Card_Prices[] card_prices { get; set; }
    }

}
