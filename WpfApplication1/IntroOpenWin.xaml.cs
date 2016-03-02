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

namespace PrimKakuro
{
    /// <summary>
    /// Interaction logic for IntroOpenWin.xaml
    /// </summary>
    public partial class IntroOpenWin : Window
    {
        public IntroOpenWin()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            WpfApplication1.Level1 newWin = new WpfApplication1.Level1();
            newWin.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
