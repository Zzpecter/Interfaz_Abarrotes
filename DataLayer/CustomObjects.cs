﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class CustomObjects
    {
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
