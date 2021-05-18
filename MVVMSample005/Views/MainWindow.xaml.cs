using MVVMSample005.ViewModels;
using System.Windows;

namespace MVVMSample005.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
