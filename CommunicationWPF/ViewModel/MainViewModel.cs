using CommunicationWPF.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Views;
using System.Windows;


namespace CommunicationWPF.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public RelayCommand CommunicationSettingsCommand { get; private set; }
        public RelayCommand DataManageCommand { get; private set; }
        public RelayCommand<Window> CloseWindowCommand { get; private set; }

        private readonly INavigationService _navigation;

        public MainViewModel(INavigationService navigation)
        {
            _navigation = navigation;

            CommunicationSettingsCommand = new RelayCommand(() =>
             {

                 _navigation.NavigateTo("CommunicationSettings");
             }
            );

            DataManageCommand = new RelayCommand(() =>
            {
                _navigation.NavigateTo("Data");
            }
            );

            CloseWindowCommand = new RelayCommand<Window>(this.CloseWindow);

        }

        public void CloseWindow(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }


    }
}