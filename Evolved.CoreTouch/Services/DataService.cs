using System.Collections.Generic;
using System.Linq;
using Cirrious.MvvmCross.Plugins.Sqlite;
using Evolved.Core.Services;

namespace Evolved.Core.ViewModels
{
    public class DataService : IDataService
    {
        private readonly ISQLiteConnection _connection;

        public DataService(ISQLiteConnectionFactory factory, IKittenGenesisService genesis)
        {
            _connection = factory.Create("one.sql");
            _connection.CreateTable<Kitten>();
            if (!_connection.Table<Kitten>().Any())
            {
                FillWithKittens(genesis);
            }
        }

        private void FillWithKittens(IKittenGenesisService genesis)
        {
            for (var i = 0; i < 100; i++)
                _connection.Insert(genesis.CreateNewKitten());
        }

        public List<Kitten> KittensMatching(string nameFilter)
        {
            return _connection
                .Table<Kitten>()
                .OrderBy(x => x.Price)
                .Where(x => x.Name.Contains(nameFilter))
                .ToList();
        }
    }
}