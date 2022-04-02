using CommunicationWPF.Views;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommunicationWPF.Services
{
    class WindowNavigationService : INavigationService
    {
        public static string Communicationsettings;
        public static string Data;
        public static string MainWindow;
        

        public WindowNavigationService()
        {
            Communicationsettings = @"CommunicationWPF\Views\CommunicationSettings.xaml";
            Data = @"CommunicationWPF\Views\DataManage.xaml";
            MainWindow= @"CommunicationWPF\Views\MainWindow.xaml";
            
        }

        public string CurrentPageKey => throw new NotImplementedException();

        public void GoBack()
        {
            throw new NotImplementedException();
        }

        public void NavigateTo(string pageKey)
        {
            if (pageKey== "CommunicationSettings")
            {
                CommunicationSettings settings = new CommunicationSettings();
                settings.Show();
            }
            else if (pageKey == "Data")
            {
                DataManage settings = new DataManage();
                settings.Show();
            }


        }

        public void NavigateTo(string pageKey, object parameter)
        {
            throw new NotImplementedException();
        }

    }
}
