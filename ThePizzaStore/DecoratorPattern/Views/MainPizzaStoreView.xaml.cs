using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DecoratorPattern
{
    /// <summary>
    /// Interaction logic for MainPizzaStoreView.xaml
    /// </summary>
    public partial class MainPizzaStoreView : Window, INotifyPropertyChanged 
    {
        DateTime startTime;

        string currentTime;
        public string CurrentTime
        {
            get => currentTime;
            set
            {
                currentTime = value;
                OnPropertyChanged("CurrentTime");
            }
        }

        public MainPizzaStoreView()
        {
            InitializeComponent();

            DispatcherTimer dt = new DispatcherTimer();
            dt.Tick += new EventHandler(dispatcherTimer_Tick);
            dt.Interval = new TimeSpan(0, 0, 1);
            dt.Start();

            startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            // Updating the Label which displays the current second
            CurrentTime = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private void OpenCloseStoreBtn_Collapsed(object sender, RoutedEventArgs e)
        {
            if (CanCollapse() == false)
            {
                OpenCloseStoreBtn.IsExpanded = true;
                MessageBox.Show("Cant close the store this early!", "WARNING!!!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

        }

        private bool CanCollapse()
        {
            TimeSpan period = DateTime.Now - startTime;
            if (period.TotalHours < 10)
                return false;
            return true;
        }
    }
}
