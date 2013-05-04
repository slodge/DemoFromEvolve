using Cirrious.MvvmCross.Plugins.Sqlite;

namespace Evolved.Core.Services
{
    public class Kitten
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
    }
}