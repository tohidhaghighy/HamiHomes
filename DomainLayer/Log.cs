using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer
{
    public class Log
    {
        public int Id { get; set; }

        [Required]
        public string LogText { get; set; }

        [Required]
        public string LogController { get; set; }

        [Required]
        public string LogView { get; set; }
    }
}
