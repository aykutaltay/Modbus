using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PLCReadWrite.Models
{
   public class requestModel
    {
        public string IpAddress { get; set; }
        public string Port { get; set; }
        //istasyon
        public string Station { get; set; }
        public string DataAddress { get; set; }
        public int ReadWrite { get; set; } //Read=0 Write=1
        public int Data { get; set; }

        //4601
        public string BlogConst { get; set; }
        public int LocalDataAddress { get; set; }
    }
}
