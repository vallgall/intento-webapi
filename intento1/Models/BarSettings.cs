using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intento1.Models
{
    public class BarSettings : IBarSettings
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Collection { get; set; }
    }

    public interface IBarSettings
    {
        string Server { get; set; }
        string Database { get; set; }
        string Collection { get; set; }
    }
}
