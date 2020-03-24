using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VM_GC_Test.Bases;
using VM_GC_Test.Common;
using VM_GC_Test.Models;

namespace VM_GC_Test.ViewModels
{
    public class VM_Main : ModelBase
    {
        public enum EPopupPage
        {
            NONE,
            [ExtensionEnum("PageA.xaml")]
            APagePopUp,
            [ExtensionEnum("PageB.xaml")]
            BPagePopUp,
        }

        private EPopupPage _popupPageA = EPopupPage.NONE;

        public EPopupPage PopupPageA
        {
            get => _popupPageA;
            set => SetProperty(ref _popupPageA, value);
        }

        private EPopupPage _popupPageB = EPopupPage.NONE;

        public EPopupPage PopupPageB
        {
            get => _popupPageB;
            set => SetProperty(ref _popupPageB, value);
        }

        private bool _PopupControllerA = false;

        public bool PopupControllerA
        {
            get => _PopupControllerA;
            set => SetProperty(ref _PopupControllerA, value);
        }

        private bool _PopupControllerB = false;

        public bool PopupControllerB
        {
            get => _PopupControllerB;
            set => SetProperty(ref _PopupControllerB, value);
        }

        private CustomObj CustomObj { get; set; }
        public List<CustomObj> LiCustomObj { get; set; }

        public VM_Main()
        {
        }

        private ICommand _PageShowACommand;

        public ICommand PageShowACommand
        {
            get => _PageShowACommand ?? (_PageShowACommand = new CommandBase(
                () =>
                {
                    if (PopupControllerA)
                    {
                        PopupControllerA = false;
                        PopupPageA = EPopupPage.NONE;
                    }
                    else
                    {
                        PopupControllerA = true;
                        PopupPageA = EPopupPage.APagePopUp;
                    }
                }, 
                () => true
                ));
        }

        private ICommand _PageShowBCommand;

        public ICommand PageShowBCommand
        {
            get => _PageShowBCommand ?? (_PageShowBCommand = new CommandBase(
                () =>
                {
                    if (PopupControllerB)
                    {
                        PopupControllerB = false;
                        PopupPageB = EPopupPage.NONE;
                    }
                    else
                    {
                        PopupControllerB = true;
                        PopupPageB = EPopupPage.BPagePopUp;
                    }
                }, 
                () => true
                ));
        }
    }
}
