

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Views;
using CommunicationWPF.Services;
using CommunicationAPI.Communication;

namespace CommunicationWPF.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<CommunicationSettingsViewModel>();
            SimpleIoc.Default.Register<DataManageViewModel>();

            SimpleIoc.Default.Unregister<INavigationService>();
            SimpleIoc.Default.Register<INavigationService, WindowNavigationService>();
            SimpleIoc.Default.Register<UDPCommunicationProtocol>();

        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public CommunicationSettingsViewModel Settings
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CommunicationSettingsViewModel>();
            }
        }

        public DataManageViewModel Data
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DataManageViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}