using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace Evolved.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged(() => Name); }
        }

        public ICommand GoCommand
        {
            get { return new MvxCommand(() => ShowViewModel<SecondViewModel>());}
        }
    }
}
