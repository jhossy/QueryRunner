using QueryConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryConsole
{
    public class QueryRunner : IQueryRunner
    {
        public TResult GetQueryResult<TResult>(IQuery<TResult> query, out long executionTime)
        {
            Stopwatch sw = Stopwatch.StartNew();

            var result = query.Execute();

            sw.Stop();
            executionTime = sw.ElapsedMilliseconds;

            return result;
        }
    }
}
