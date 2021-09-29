using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson3
{
    public class Item
    {
        public Item(string itemname)
        {
            ItemName = itemname;
        }

        public Item(int itemlength)
        {
            ItemLength = itemlength;
        }

        public Item(int itemwidth)
        {
            ItemWidth = itemwidth;
        }

        public Item(int itemweight)
        {
            ItemWeight = itemweight;
        }
        public string ItemName { get; set; }
        public int ItemLength { get; set; }
        public int ItemWeight { get; set; }
        public int ItemWidth { get; set; }
    }
}
