using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] items;
        TValue[] items2;

        public MyDictionary()
        {
            items = new TKey[0];
            items2 = new TValue[0];
        }
        public void Add(TKey item,TValue item2)
        {
            TKey[] TempItem = items;
            TValue[] TempItem2 = items2;
            items = new TKey[items.Length + 1];
            items2 = new TValue[items2.Length + 1];
            for (int i = 0; i < TempItem.Length; i++)
            {
                items[i] = TempItem[i];
                items2[i] = TempItem2[i];
            }
            items[items.Length - 1] = item;
            items2[items2.Length - 1] = item2;
        }
        
        public int Count
        {
            get { return items.Length; }
        }
    }
}
