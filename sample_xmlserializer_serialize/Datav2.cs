using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_xmlserializer_serialize.Datav2
{

    public class DataChild
    {
        public int dataChild1 = 19;
    }

    public class Data
    {
        public int data3 = 18;
        public List<string> data2 = new List<string>{"xx", "yy"};
        public DataChild child2;
    }
}
