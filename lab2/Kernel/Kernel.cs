﻿using System;
using Exporter.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel
{
    public class Kernel
    {
        private Dictionary <Type, Object> _dict;

        public Kernel()
        {
            this._dict = new Dictionary<Type, object>();
            this._dict.Add(typeof(IExporter), new TxtExporter.TxtExporter());
        }

        public T Get<T>()
        {
            var res = this._dict[typeof(T)];
            return (T)res;
        }
    }
}
