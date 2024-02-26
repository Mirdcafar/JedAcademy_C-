namespace ConsoleApp1.MyLIst
{
    using System;

    class MyList<T>
    {
        private T[] array;
        private int capacity;
        private int count;

        public MyList()
        {
            capacity = 5; 
            array = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity *= 2;
                Array.Resize(ref array, capacity);
            }

            array[count] = item;
            count++;
        }

        public void PrintList()
        {
            Console.WriteLine("MyList elements:");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine();
        }

        public void Remove(T item)
        {
            int index = Array.IndexOf(array, item);

            if(index != -1)
            {
                for(int i = index; i < count - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                count--;
            }
        }

        public T Min()
        {
            T min = array[0];
            for (int i = 1; i < count; i++)
            {
                if (Comparer<T>.Default.Compare(array[i], min) < 0)
                {
                    min = array[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = array[0];
            for (int i = 1; i < count; i++)
            {
                if (Comparer<T>.Default.Compare(array[i], max) > 0)
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
