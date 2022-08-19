using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestHPA
{
    public class TestHPA
    {
        public string Name { get; set; }

        public string GetName()
        {
            for (int i = 1; i <= 10000; i++)
            {
                Name += "TestHPACalled " + i.ToString() + " Time"+Environment.NewLine;
            }
            return Name;
        }
    }
}
