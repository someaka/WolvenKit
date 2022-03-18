using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    [RED("array")]
    public class CArray<T> : CArrayBase<T> where T : IRedType
    {
        public CArray()
        {

        }

        public CArray(int size) : base(size)
        {

        }

        public CArray(List<T?> list) : base(list)
        {

        }
    }
}
