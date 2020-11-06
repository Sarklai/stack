using System;
using System.Collections.Generic;
using System.Linq;

namespace stack_test.Model
{
    public class simplestack <T>
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public bool IsEmpty => items.Count == 0;

        public void Push(T item)    // Операция ввода
        {
            items.Add(item);
        }

        public T Pop()  // Операция вывода
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Пустой стек");
            }
        }

        public T Peek() // Пик
        {
            if (!IsEmpty)
            {
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Пустой стек");
            }
        }

        public override string ToString()
        {
            return $"Стек с {Count} элементами";
        }
    }
}
