using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezmobile_Futures.Views
{
    public class DatLenhPageMasterMenuItem
    {
        public DatLenhPageMasterMenuItem()
        {
            TargetType = typeof(DatLenhPageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}