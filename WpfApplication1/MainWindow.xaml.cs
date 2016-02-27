using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1
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

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            string box1, box2, box3, box4, box5, box6, box7, box8, box9;
            box1 = text1.Text;
            box2 = text2.Text;
            box3 = text3.Text;
            box4 = text4.Text;
            box5 = text5.Text;
            box6 = text6.Text;
            box7 = text7.Text;
            box8 = text8.Text;
            box9 = text9.Text;
            if (box1 == "6" && box2 == "1" && box3 == "9" &&
                box4 == "2" && box5 == "6" && box6 == "4" &&
                box4 == "2" && box5 == "6" && box6 == "4")
            {
                //correct solution
                System.Console.WriteLine("Hello Correct");
                System.Console.ReadLine();

                PrimKakuro.Window1 newWin = new PrimKakuro.Window1();
                newWin.Show();
                //this.Close();
            }
            else
            {
                //wrong solution
                System.Console.WriteLine("Hello Wrong");
                System.Console.ReadLine();


            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
