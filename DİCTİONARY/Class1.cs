using dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        void Main(string[] args)
        {
            mylist<int, string> ogrenciler = new mylist<int, string>();
            ogrenciler.add(1, "yusuf");
            ogrenciler.add(2, "yusuf");
            ogrenciler.add(3, "yusuf");
            ogrenciler.add(4, "yusuf");
            ogrenciler.add(5, "yusuf");


        }

    }
}
