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
    /// Логика взаимодействия для EngineerPage.xaml
    /// </summary>
    public partial class EngineerPage : Page
    {
        public EngineerPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExpBox.Text = ((Button)sender).Tag.ToString() != "clear" && ((Button)sender).Tag.ToString() != "del" && ((Button)sender).Tag.ToString() != "=" ? ExpBox.Text + ((Button)sender).Tag :
                ((Button)sender).Tag.ToString() != "clear" && ((Button)sender).Tag.ToString() != "del" ? new org.mariuszgromada.math.mxparser.Expression(ExpBox.Text).calculate().ToString() :
                   ((Button)sender).Tag.ToString() != "clear" ? ExpBox.Text.Length > 0 ? ExpBox.Text.Remove(ExpBox.Text.Length - 1) : "" : "";
        }

        
    }
}
