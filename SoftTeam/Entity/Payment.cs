using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftTeam.Entity
{
    internal class Payment
    {
        public int no { set; get; }
        public string category { set; get; }
        public string name { set; get; }
        public string remark { set; get; }
        public string date { set; get; }
        public int price { set; get; }
        public int status { set; get; }
        public int requirmentAmount { set; get; }
    }
}
