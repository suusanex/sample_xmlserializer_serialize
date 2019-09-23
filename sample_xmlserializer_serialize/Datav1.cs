using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_xmlserializer_serialize.Datav1
{
    public class DataChild
    {
        public int dataChild1;
    }

    public class Data
    {
        public int data1;
        public List<string> data2;
        public DataChild child;
    }
}
