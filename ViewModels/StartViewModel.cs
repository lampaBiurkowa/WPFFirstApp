using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace wpf
{
    public class StartViewModel : INotifyPropertyChanged
    {
        private User user;
        public ICommand ClickCommand { get; set; }

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
            ClickCommand = new ClickCommand(handleButtonClicked, canClickButton);
        }

        private bool canClickButton(object parameter)
        {
            return !string.IsNullOrWhiteSpace(user.Description);
        }

        private void handleButtonClicked(object parameter)
        {
            MessageBox.Show("Hello... ");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}