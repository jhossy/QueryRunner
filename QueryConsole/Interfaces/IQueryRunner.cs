using QueryConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryConsole.Interfaces
{
    interface IQueryRunner
    {
        TResult GetQueryResult<TResult>(IQuery<TResult> query, out long executionTime);
    }
}
