using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{


    class mylist<Tkey, Tvalue>
    {

        Tkey[] array;
        Tvalue[] Aarray;
        Tkey[] temparray;
        Tvalue[] tempAarray;

        public mylist()
        {
            array = new Tkey[0];
            Aarray = new Tvalue[0];
        }

        public void add(Tkey key, Tvalue value)
        {
            //int sayi = 0;
            temparray = array;
            tempAarray = Aarray;
            array = new Tkey[array.Length + 1];
            Aarray = new Tvalue[Aarray.Length + 1];
            for (int i = 0; i < temparray.Length; i++)
            {
                temparray[i] = array[i];
            }

            for (int i = 0; i < tempAarray.Length; i++)
            {
                tempAarray[i] = Aarray[i];
            }

            array[array.Length - 1] = key;
            Aarray[Aarray.Length - 1] = value;

            Console.ReadLine();
        }


    }
}
