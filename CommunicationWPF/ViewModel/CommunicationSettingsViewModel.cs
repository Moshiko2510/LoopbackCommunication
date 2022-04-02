using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationAPI.Communication;

namespace CommunicationWPF.ViewModel
{
    public class CommunicationSettingsViewModel : ViewModelBase
    {
        public UDPCommunicationSettings settings { get; private set; }
        public RelayCommand Connect { get; private set; }

        public CommunicationSettingsViewModel()
        {
            Connect = new RelayCommand(() =>
            {
                UDPCommunicationProtocol.Connect();
            }
);
        }
    }
}
