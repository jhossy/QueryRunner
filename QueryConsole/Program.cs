using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryRunner qr = new QueryRunner();

            ConcreteIntQuery intQuery = new ConcreteIntQuery();
            ConcreteStringQuery stringQuery = new ConcreteStringQuery();

            long intExecutionTime, stringExecutionTime;

            IEnumerable<int> intResult = qr.GetQueryResult(intQuery, out intExecutionTime);
            IEnumerable<string> stringResult = qr.GetQueryResult(stringQuery, out stringExecutionTime);

            Console.WriteLine("Result for int query : " + string.Join(",", intResult) + " in time: " + intExecutionTime);
            Console.WriteLine("Result for string query : " + string.Join(",", stringResult) + " in time: " + stringExecutionTime);
            Console.ReadLine();
        }
    }
}
