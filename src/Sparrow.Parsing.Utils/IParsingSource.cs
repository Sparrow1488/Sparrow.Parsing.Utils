﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sparrow.Parsing.Utils
{
    public interface IParsingSource
    {
        Task<string> GetAsync();
        public IEnumerable<IParsingSource> Bindings { get; }
    }
}