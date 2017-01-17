using QueryConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryConsole
{
    public class ConcreteStringQuery : IQuery<IEnumerable<string>>
    {
        public IEnumerable<string> Execute()
        {
            return new List<string>() { "a", "b", "c" };
        }
    }
}
