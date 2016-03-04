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
    /// Interaction logic for Level2.xaml
    /// </summary>
    public partial class Level2 : Window
    {
        public Level2()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            int box12 = Convert.ToInt32(text12.Text);
            int box22 = Convert.ToInt32(text22.Text);
            int box32 = Convert.ToInt32(text32.Text);
            int box42 = Convert.ToInt32(text42.Text);
            int box52 = Convert.ToInt32(text52.Text);
            int box62 = Convert.ToInt32(text62.Text);
            int box72 = Convert.ToInt32(text72.Text);
            int box82 = Convert.ToInt32(text82.Text);
            int box92 = Convert.ToInt32(text92.Text);
            int box102 = Convert.ToInt32(text102.Text);
            int box112 = Convert.ToInt32(text112.Text);
            int box122 = Convert.ToInt32(text122.Text);
            int box132 = Convert.ToInt32(text132.Text);
            int box142 = Convert.ToInt32(text142.Text);
            int box152 = Convert.ToInt32(text152.Text);
            int box162 = Convert.ToInt32(text162.Text);

            if ((box12 + box22 + box32 + box42 == 17) &&
                (box52 + box62 + box72 + box82 == 21) &&
                (box92 + box102 + box112 + box122 == 24) &&
                (box132 + box142 + box152 + box162 == 15) &&

                (box12 + box52 + box92 + box132 == 17) &&
                (box22 + box62 + box102 + box142 == 23) &&
                (box32 + box72 + box112 + box152 == 22) &&
                (box42 + box82 + box122 + box162 == 15))
            {
                //correct solution
                /*System.Console.WriteLine("Hello Correct");
                System.Console.ReadLine();*/

                PrimKakuro.WinningWindow newWin = new PrimKakuro.WinningWindow();
                newWin.Show();
                this.Close();
            }
            else
            {
                //wrong solution
                /*System.Console.WriteLine("Hello Wrong");
                System.Console.ReadLine();*/

                PrimKakuro.LosingWindow newWin = new PrimKakuro.LosingWindow();
                newWin.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
