using System.Windows;

namespace wpf
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        private StartViewModel viewModel;

        public Start()
        {
            InitializeComponent();
            viewModel = new StartViewModel();
            DataContext = viewModel;
        }
    }
}
