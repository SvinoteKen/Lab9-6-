using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9__6_.List
{
    public class SecondNode<SecondList>
    {
        public SecondNode(SecondList data)
        {
            Data = data;
        }
        public SecondList Data { get; set; }
        public SecondNode<SecondList> Previous { get; set; }
        public SecondNode<SecondList> Next { get; set; }
    }
}
