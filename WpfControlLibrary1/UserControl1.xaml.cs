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
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void CalcSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (gg != null)
            {
                gg.Source = CalcSelector.SelectedIndex == 0 ? new Uri("StandartPage.xaml", UriKind.Relative) :
                    CalcSelector.SelectedIndex == 1 ? new Uri("EngineerPage.xaml", UriKind.Relative) :
                    CalcSelector.SelectedIndex == 2 ? new Uri("ProgrammerPage.xaml", UriKind.Relative) : new Uri("DatePage.xaml", UriKind.Relative);
            }

        }
    }
}
