﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tianyue.Command
{
    public interface ICommand
    {
        Guid Id { get; }
    }
}
