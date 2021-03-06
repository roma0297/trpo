﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public interface IPublisher
    {
        event EventHandler<Location> LocationChanged;
    }

    public interface IScalable
    {
        event EventHandler<int> AreaChanged;
    }
}
