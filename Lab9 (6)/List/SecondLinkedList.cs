using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9__6_.List
{
    public class SecondLinkedList<SecondList> : IEnumerable<SecondList>
    {
        SecondNode<SecondList> head;
        SecondNode<SecondList> tail;
        int count;
        public void Add(SecondList data)
        {
            var node = new SecondNode<SecondList>(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst(SecondList data)
        {
            var node = new SecondNode<SecondList>(data);
            SecondNode<SecondList> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<SecondList> IEnumerable<SecondList>.GetEnumerator()
        {
            SecondNode<SecondList> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

    }
}
