using System.Collections.Generic;
using System.Linq;
using Cirrious.MvvmCross.Plugins.Sqlite;
using Cirrious.MvvmCross.ViewModels;
using Evolved.Core.Services;

namespace Evolved.Core.ViewModels
{
    public class SecondViewModel
        : MvxViewModel
    {
        private readonly IDataService _dataService;

        public SecondViewModel(IDataService dataService)
        {
            _dataService = dataService;
            Update();
        }

        private string _filter = "string";
        public string Filter
        {
            get { return _filter; }
            set { _filter = value; RaisePropertyChanged(() => Filter); Update(); }
        }

        private List<Kitten> _kittens;
        public List<Kitten> Kittens
        {
            get { return _kittens; }
            set { _kittens = value; RaisePropertyChanged(() => Kittens); }
        }
        
        private void Update()
        {
            Kittens = _dataService.KittensMatching(Filter);
        }
    }
}