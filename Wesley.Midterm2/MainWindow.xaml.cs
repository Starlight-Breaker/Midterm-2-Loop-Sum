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

namespace Wesley.Midterm2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGetSum_Click(object sender, RoutedEventArgs e)
        {
            int Start = int.Parse(txtStart.Text);
            int End = int.Parse(txtEnd.Text);
            int Sum = 0;

            for (int x = Start; x <= End; ++x)
            {
                Sum += x;
            }
            lblResult.Content = Sum.ToString();
        }
    }
}
