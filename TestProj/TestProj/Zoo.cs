using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    internal class Zoo<T>
    {
        internal T curAnimal;

        internal void SetAnimal(T animal)
        {
            curAnimal = animal;
        }
    }
}
