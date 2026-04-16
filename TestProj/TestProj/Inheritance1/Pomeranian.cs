using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    internal class Pomeranian : Dog
    {
        public void PrintInfo()
        {
            Console.WriteLine($"이 포메라니안의 이름 : {name}");
        }
    }
}
