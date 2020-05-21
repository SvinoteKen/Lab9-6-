using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9__6_.List
{
    public class DoublyLinkedList<DoubleList> : IEnumerable<DoubleList>
    {
        DoublyNode<DoubleList> head;
        DoublyNode<DoubleList> tail;
        int count;
        public void Add(DoubleList data)
        {
            var node = new DoublyNode<DoubleList>(data);

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
        public void AddFirst(DoubleList data)
        {
            var node = new DoublyNode<DoubleList>(data);
            DoublyNode<DoubleList> temp = head;
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

        public bool Contains(DoubleList data)
        {
            DoublyNode<DoubleList> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<DoubleList> IEnumerable<DoubleList>.GetEnumerator()
        {
            DoublyNode<DoubleList> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerable<DoubleList> BackEnumerator()
        {
            DoublyNode<DoubleList> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }

        public DoublyNode<DoubleList> SearchElement(int index)
        {
            DoublyNode<DoubleList> Prev = tail;
            DoublyNode<DoubleList> Next = head;
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index < ((count + 1) / 2))
            {
                if (index == 0)
                {
                    return head;
                }

                for (; index != 0; index--)
                {
                    Next = Next.Next;
                }

                return Next;
            }
            else
            {
                for (; index < count; index++)
                {
                    Prev = Prev.Previous;
                }

                return Prev;
            }
        }
    
    }
}
