using System.Collections.Generic;

namespace Evolved.Core.Services
{
    public interface IDataService
    {
        List<Kitten> KittensMatching(string nameFilter);
    }
}