using Devfx.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devfx.Service
{
    public class Peration : IPeration
    {
        public int Add(int a, int b) => a + b;
    }
}
