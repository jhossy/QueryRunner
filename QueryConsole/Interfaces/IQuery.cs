﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryConsole.Interfaces
{
    public interface IQuery<TResult>
    {
        TResult Execute();
    }
}
