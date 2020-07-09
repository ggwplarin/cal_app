using System.Windows;
using System.Windows.Controls;

namespace WpfControlLibrary1
{
    public partial class StandartPage : Page
    {
        public StandartPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExpBox.Text = ((Button)sender).Tag.ToString() != "clear" && ((Button)sender).Tag.ToString() != "del" && ((Button)sender).Tag.ToString() != "=" ? ExpBox.Text + ((Button)sender).Tag :
                ((Button)sender).Tag.ToString() != "clear" && ((Button)sender).Tag.ToString() != "del" ?  new org.mariuszgromada.math.mxparser.Expression(ExpBox.Text).calculate().ToString():
                   ((Button)sender).Tag.ToString() != "clear"?ExpBox.Text.Length>0? ExpBox.Text.Remove(ExpBox.Text.Length-1):"":"" ;
        }
    }
}
