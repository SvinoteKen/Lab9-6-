using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9__6_.List
{
    public class DoublyNode<DoubleList>
    {
        public DoublyNode(DoubleList data)
        {
            Data = data;
        }
        public DoubleList Data { get; set; }
        public DoublyNode<DoubleList> Previous { get; set; }
        public DoublyNode<DoubleList> Next { get; set; }
    }
}
