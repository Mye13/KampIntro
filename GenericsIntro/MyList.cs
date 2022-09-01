using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{   
    //string veya int... değil herhangi bir türde veri 
    //girebilsin kullanıcı yani T türünde (type)
    class MyList<T>
    {
        T[] items;
        //constructor bloğu new dendiği anda çalışır
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
