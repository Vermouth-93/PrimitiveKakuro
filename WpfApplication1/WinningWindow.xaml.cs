﻿using System;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class WinningWindow : Window
    {
        public WinningWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            IntroOpenWin newWin = new IntroOpenWin();
            newWin.Show();
            this.Close();
        }
    }
}