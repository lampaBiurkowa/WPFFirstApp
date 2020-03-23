using System;

namespace wpf
{
    public enum Vegetable
    {
        POTATO,
        CABBAGE,
        CARROT
    }

    class User
    {
        public Vegetable FavouriteVegetable { get; set; }
        public string Description { get; set; }
        public DateTime ConfirmDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }

        public User(string description, Vegetable favouriteVegetable, DateTime updateDateTime)
        {
            Description = description;
            FavouriteVegetable = favouriteVegetable;
            UpdateDateTime = updateDateTime;
        }

        public User() { }
    }
}
