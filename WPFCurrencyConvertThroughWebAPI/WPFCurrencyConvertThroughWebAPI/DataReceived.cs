using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCurrencyConvertThroughWebAPI
{
    internal class Root
    {
        public string disclaimer { get; set; }
        public string license { get; set; }
        public long timestamp { get; set; }
      
        public Rate rates { get; set; }

    }
}
