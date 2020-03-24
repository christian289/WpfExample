using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel_GCTargetTest
{
    public class VM_A
    {
        private CustomObj CustomObj_A { get; set; }
        public List<CustomObj> LiCustomObj_A { get; set; }

        public VM_A(CustomObj a, List<CustomObj> Lia)
        {
            CustomObj_A = a;
            LiCustomObj_A = Lia;
        }
    }
}
