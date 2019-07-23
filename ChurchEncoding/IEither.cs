﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploeh.Samples.ChurchEncoding
{
    public interface IEither<L, R>
    {
        T Match<T>(IEitherParameters<L, R, T> parameters);
    }
}
