using System.Windows;

namespace Desktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainWindowViewModel();

            this.tabControl.SelectedIndex = 0;
        }
    }
}
