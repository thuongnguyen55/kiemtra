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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kiemtraketthucmon
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

        private void btnMeo_Click(object sender, RoutedEventArgs e)
        {
            Meo Meo = new Meo();
            Meo.keu = "Meo meo";
            Meo.MauLongdv = "vang";
            Meo.Talk();
        }

        private void BtnCho_Click(object sender, RoutedEventArgs e)
        {
            Cho cho = new Cho();
            cho.keu = "Gau gau";
            cho.MauLongdv = "den";
            cho.Talk();
        }
    }
}
