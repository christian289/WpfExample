using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Input;
using VM_GC_Test.Bases;
using VM_GC_Test.Models;

namespace VM_GC_Test.ViewModels
{
    public class VM_A : ModelBase
    {
        private VM_Main ParentViewModel;
        private CustomObj CustomObj_A { get; set; } = new CustomObj();
        public List<CustomObj> LiCustomObj_A { get; set; } = new List<CustomObj>();

        public VM_A()
        {
        }

        private ICommand _GetObjectCommand;

        public ICommand GetObjectCommand
        {
            get => _GetObjectCommand ?? new CommandBase(
                () =>
                {
                },
                () => true
                );
        }
    }
}
