using System;
using System.Collections.Generic;
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

namespace WpfControlLibrary1
{
    /// <summary>
    /// Логика взаимодействия для DatePage.xaml
    /// </summary>
    public partial class DatePage : Page
    {
        public DatePage()
        {
            InitializeComponent();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            ResBox.Text = First.SelectedDate.HasValue && Second.SelectedDate.HasValue ? $"{((TimeSpan)(Second.SelectedDate - First.SelectedDate)).Days}d" : "";
        }
    }
}
