﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploeh.Samples.ChurchEncoding
{
    public interface IEither<L, R>
    {
        T Match<T>(Func<L, T> onLeft, Func<R, T> onRight);
    }
}
