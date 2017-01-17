using QueryConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryConsole
{
    public class ConcreteIntQuery : IQuery<IEnumerable<int>>
    {
        public IEnumerable<int> Execute()
        {
            return new List<int>() { 1, 2, 3 };
        }
    }
}
