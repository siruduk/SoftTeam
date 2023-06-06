using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftTeam.Entity
{
    internal class UsedLog
    {
        public int No { get; set; }
        public string Date { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public string Remark { get; set; }
        public int UsedAmount { get; set; }
    }
}
