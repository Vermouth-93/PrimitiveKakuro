using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Level1 : Window
    {
        public Level1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        

        private void textBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            int box1, box2, box3, box4, box5, box6, box7, box8, box9;
            box1 = box2 = box3 = box4 = box5 = box6 = box7 = box8 = box9 = 0;

            if( text1.Text != null )
            {
                box1 = Int16.Parse(text1.Text);
            }
            
            if( text2.Text != null )
            {
                box2 = Int16.Parse(text2.Text);
            }

            if( text3.Text != null )
            {
                box3 = Int16.Parse(text3.Text);
            }

            if( text4.Text != null )
            {
                box4 = Int16.Parse(text4.Text);
            }

            if( text5.Text != null )
            {
                box5 = Int16.Parse(text5.Text);
            } 
            
            if( text6.Text != null )
            {
                box6 = Int16.Parse(text6.Text);
            } 
            
            if( text7.Text != null )
            {
                box7 = Int16.Parse(text7.Text);
            }
            
            if( text8.Text != null )
            {
                box8 = Int16.Parse(text8.Text);
            } 
            
            if( text9.Text != null )
            {
                box9 = Int16.Parse(text9.Text);
            }

            if ( (box1 + box2 + box3 == 16) &&
                 (box4 + box5 + box6 == 12) &&
                 (box7 + box8 + box9 == 17) &&
                 (box1 + box4 + box7 == 16) &&
                 (box2 + box5 + box8 == 9)  &&
                 (box3 + box6 + box9 == 21) )
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
