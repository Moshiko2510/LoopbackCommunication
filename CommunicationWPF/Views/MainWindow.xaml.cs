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

namespace CommunicationWPF.Views
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

        //private void CloseApp(object sender, RoutedEventArgs e)
        //{
        //    SystemCommands.CloseWindow(this);
        //}

        //private void SettingsPage(object sender, RoutedEventArgs e)
        //{
        //    CommunicationSettings settings = new CommunicationSettings();
        //    settings.Show();
        //}

        //private void DataManage(object sender, RoutedEventArgs e)
        //{
        //    DataManage data = new DataManage();
        //    data.Show();
            
        //}
    }
}