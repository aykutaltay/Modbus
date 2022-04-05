using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PLCReadWrite.Models
{
   public class responseModel
    {
        public string ResponseStatus { get; set; }
        public string Error { get; set; }
        public string ResponseData { get; set; }
    }
}
