using System;
using System.ComponentModel;

namespace wpf
{
    public class StartViewModel : INotifyPropertyChanged
    {
        private User user;
        private bool Inited = false;

        public string Description
        {
            get => user.Description;
            set
            {
                user.Description = value;
                user.UpdateDateTime = DateTime.Now;
                OnPropertyChange("Description");
                OnPropertyChange("UpdateDateTime");
            }
        }

        public Vegetable FavouriteVegetable
        {
            get => user.FavouriteVegetable;
            set
            {
                user.FavouriteVegetable = value;
                OnPropertyChange("FavouriteVegetable");
                OnPropertyChange("UpdateDateTime");
            }
        }

        public DateTime UpdateDateTime
        {
            get => user.UpdateDateTime;
            set
            {
                user.UpdateDateTime = value;
                OnPropertyChange("UpdateDateTime");
            }
        }

        public StartViewModel()
        {
            user = new User();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}