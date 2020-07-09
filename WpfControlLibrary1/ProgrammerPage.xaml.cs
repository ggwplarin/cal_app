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
    /// Логика взаимодействия для ProgrammerPage.xaml
    /// </summary>
    public partial class ProgrammerPage : Page
    {
        public ProgrammerPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExpBox.Text = ((Button)sender).Tag.ToString() != "del" ? ExpBox.Text + ((Button)sender).Tag :
                   ExpBox.Text.Length > 0 ? ExpBox.Text.Remove(ExpBox.Text.Length - 1) : "";
            if (!string.IsNullOrEmpty(ExpBox.Text))
            {
                x2Box.Text = Convert.ToString(int.Parse(ExpBox.Text), 2);
                x8Box.Text = Convert.ToString(int.Parse(ExpBox.Text), 8);
                x16Box.Text = Convert.ToString(int.Parse(ExpBox.Text), 16);
            }

        }
        
    }
}
