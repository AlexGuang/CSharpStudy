using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning
{
    internal class ElectronicDevice
    {
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public int CurrentChannel
        {
            get;
            set;
        }
        public int StockCurrentNum { get; set; }

        public ElectronicDevice(bool isOn, string brand,  int stock)
        {
            this.IsOn = isOn;
            this.Brand = brand;
            this.CurrentChannel = 0;
            StockCurrentNum = stock;
        }
        public ElectronicDevice()
        {

        }

        
        public void SwitchOn()
        {
            this.IsOn = true;
         
        }

        public void SwitchOff()
        {
            this.IsOn = true;
           
        }

        public void ChangeChannal()
        {
           this.CurrentChannel++;
        }

    }
}
