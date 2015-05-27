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
using System.Windows.Shapes;

namespace ButtonDisableTutorial
{
    /// <summary>
    /// Interaction logic for subWindow1.xaml
    /// </summary>
    public partial class subWindow1 : Window
    {
        public subWindow1()
        {
            InitializeComponent();
        }

        private void txtBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox.Text))
            {
                this.txtBox.Visibility = System.Windows.Visibility.Hidden;
                this.waterMark.Visibility = System.Windows.Visibility.Visible;
                this.waterMark.Focus();
            }
        }

        private void waterMark_GotFocus(object sender, RoutedEventArgs e)
        {
            this.waterMark.Visibility = System.Windows.Visibility.Hidden;
            this.txtBox.Visibility = System.Windows.Visibility.Visible;
            this.txtBox.Focus();
        }
    }
}
