using System;
using System.Windows.Input;

namespace WpfApplication1
{
    public partial class MainWindow
    {
        private RelayCommand _goToPage;
        public ICommand CmdGoToPage => _goToPage ?? (_goToPage = new RelayCommand(GoToPage));

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }

        public void GoToPage(object o)
        {
            LinkNavigator.Navigate(NavigationTarget, new Uri((string)o, UriKind.Relative));
        }
    }
}
