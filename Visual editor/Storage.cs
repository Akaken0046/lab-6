namespace Visual_editor
{
    public class Storage<T>
    {
        private class Node<T>
        {
            public T data;
            public Node<T> next;
            public Node<T> prev;

            public Node(T data, Node<T> next = null, Node<T> prev = null)
            {
                this.data = data;
                this.next = next;
                this.prev = prev;
            }

        }

        private int size;
        private int index;
        private Node<T> current;
        private Node<T> head;

        public Storage()
        {
            size = 0;
            index = 0;
            head = null;
            current = null;
        }

        public void Add(T data)
        {
            Node<T> temp = new Node<T>(data);
            if (current == null)
            {
                head = current = temp;
                current.prev = current.next = temp;
            }
            else
            {
                Node<T> afterCurrent = current.next;
                temp.next = afterCurrent;
                afterCurrent.prev = temp;
                current.next = temp;
                temp.prev = current;
                current = temp;
            }
            size++;
        }

        public void RemoveCurrent()
        {
            if (current == null)
            {
                return;
            }
            if (current == head)
            {
                head = current.next;
            }

            Node<T> afterCurrent = current.next;
            Node<T> beforeCurrent = current.prev;
            afterCurrent.prev = beforeCurrent;
            beforeCurrent.next = afterCurrent;
            T value = current.data;
            Node<T> del = current;
            current = afterCurrent;
            del = del.next = del.prev = null;
            if (GetSize() == 1)
                current = head = null;
            size--;
        }

        public void RemoveByIndex(int number)
        {
            SetIndex(number);
            if (index == FindIndex(current.data))
            {
               RemoveCurrent();
               return;
            }
            if (index == 0)
            {
                Node<T> del = head;
                T value = head.data;
                head.next.prev = head.prev;
                head.prev.next = head.next;
                head = head.next;
                del = del.next = del.prev = null;
                size--;

            }
            else
            {
                Node<T> previous = head;
                for (int i = 0; i < index - 1; i++)
                    previous = previous.next;
                if (previous.next == current)
                {
                    RemoveCurrent();
                    return;
                }
                Node<T> del = previous.next;
                previous.next = del.next;
                del.next.prev = previous;
                del = del.next = del.prev = null;
                size--;
            }
        }
        public T CurrentObject()
        {
            if (current != null)
            {
                return current.data;
            }
            return default(T);
        }

        public T PrevObject()
        {
            return current.prev.data;
        }

        public T NextObject()
        {
            return current.next.data;
        }

        public T PNext()
        {
            return current.next.data;
        }

        public void SetIndex(int index)
        {
            this.index = index;
        }

        public void SetCurrent(T Data)
        {
            Node<T> temp = head;
            do
            {
                if (temp.data.Equals(Data))
                {
                    current = temp;
                    return;
                }
                else
                {
                    temp = temp.next;
                }
            } while (temp != head);
        }

        public void First()
        {
            index = 0;
        }

        public void Next()
        {
            index++;
        }

        public void Prev()
        {
            index--;
        }

        public bool IsEOL()
        {
            return index == size;
        }

        public T GetObject()
        {
            int counter = 0;
            Node<T> temp = head;
            do
            {
                if (counter == index)
                {
                    return temp.data;
                }
                else
                {
                    temp = temp.next;
                    counter++;
                }
            } while (temp != head);
            return default(T);
        }

        public int GetSize()
        {
            return size;
        }

        public int FindIndex(T Data)
        {
            Node<T> temp = head;
            int count = 0;
            do
            {
                if (temp.data.Equals(Data))
                {
                    return count;
                }
                else
                {
                    temp = temp.next;
                    count++;
                }
            } while (temp != head);
            return -1;
        }

        ~Storage()
        {
            while (size != 0)
            {
                Node<T> temp = head;
                head = head.next;
                temp = temp.next = temp.prev = null;
                size--;
            }
        }
    }
}
