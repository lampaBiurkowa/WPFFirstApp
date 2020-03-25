using System;
using System.ComponentModel;
using System.Windows.Input;

namespace wpf
{
    public class StartViewModel : INotifyPropertyChanged
    {
        private User user;
        public ICommand ClickCommand { get; set; }

        public DateTime ConfirmDateTime
        {
            get => user.ConfirmDateTime;
            set
            {
                user.ConfirmDateTime = value;
                OnPropertyChange(nameof(ConfirmDateTime));
            }
        }

        public string Description
        {
            get => user.Description;
            set
            {
                user.Description = value;
                user.UpdateDateTime = DateTime.Now;
                OnPropertyChange(nameof(Description));
                OnPropertyChange(nameof(UpdateDateTime));
            }
        }

        public Vegetable FavouriteVegetable
        {
            get => user.FavouriteVegetable;
            set
            {
                user.FavouriteVegetable = value;
                OnPropertyChange(nameof(FavouriteVegetable));
                OnPropertyChange(nameof(UpdateDateTime));
            }
        }

        public DateTime UpdateDateTime
        {
            get => user.UpdateDateTime;
            set
            {
                user.UpdateDateTime = value;
                OnPropertyChange(nameof(UpdateDateTime));
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
            ConfirmDateTime = DateTime.Now;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}