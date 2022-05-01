using System;

namespace TrainingSixteen
{
    class PrintService<T>
    {
        private T[] Values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            Values[_count] = value;
            _count++;
        }

        public T First()
        {
            if(_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return Values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int x = 0; x < _count - 1; x++)
            {
                Console.Write(Values[x] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(Values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
