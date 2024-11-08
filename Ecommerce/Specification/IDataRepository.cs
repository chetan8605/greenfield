﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using POCOLib;

namespace Specification
{
    public interface IDataRepository
    {
        bool Serialize(string filname, List<Product> products);

        List<Product> Deserialize(string filename);
        
    }
}
