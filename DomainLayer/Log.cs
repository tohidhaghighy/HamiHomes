using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    public class Log
    {
        public int Id { get; set; }
        public string LogText { get; set; }
        public string LogController { get; set; }
        public string LogView { get; set; }
    }
}
