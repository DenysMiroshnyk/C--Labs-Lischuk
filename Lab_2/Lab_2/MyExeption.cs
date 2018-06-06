using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class MyExeption : ArgumentException
    {
        MyExeption(String s) : base("MyExeption: " + s) { }
    }

}
