using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationAPI.Communication
{
    public class UDPCommunicationSettings : INotifyPropertyChanged
    {
        public string sourceIP;
        public string sourcePort;
        public string destIP;
        public string destPort;

        public event PropertyChangedEventHandler PropertyChanged;

        public UDPCommunicationSettings()
        {

        }

        


        //public UDPCommunicationSettings(string sIP, string sPort, string dIP, string dPort)
        //{
        //    sourceIP = sIP;
        //    sourcePort = sPort;
        //    destIP = dIP;
        //    destPort = dPort;
        //}

    }
}
