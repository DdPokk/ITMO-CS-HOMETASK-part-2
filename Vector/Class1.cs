using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector
    {
        private int[] vector;

        public Vector(int count)
        {
            vector = new int[count];
        }

        public Vector(int[] arr)
        {
            vector = new int[arr.Length];
            for (int i = 0; i < arr.Length; ++i)
                vector[i] = arr[i];
        }

        public int Length
        {
            get
            {
                return vector.Length;
            }
            
        }

        public int this[int idx]
        {
            get
            {
                if (idx > vector.Length - 1)
                    throw new IndexOutOfRangeException();
                return vector[idx];
            }
            set
            {
                if (idx > vector.Length - 1)
                    throw new IndexOutOfRangeException();
                vector[idx] = value; 
            }
        }

        public Vector Sum(Vector vect)
        {
            if (vect.Length != this.Length)
                throw new ArithmeticException();
            Vector retVector = new Vector(this.Length);
            for (int i = 0; i < vector.Length; ++i)
            {
                retVector[i] = this[i] + vect[i];
            }
            return retVector;
        }

        public Vector Substract(Vector vect)
        {
            if (vect.Length != this.Length)
                throw new ArithmeticException();
            Vector retVector = new Vector(this.Length);
            for (int i = 0; i < vector.Length; ++i)
            {
                retVector[i] = this[i] - vect[i];
            }
            return retVector;
        }

        public void Multiplie(int m)
        {
            for (int i = 0; i < vector.Length; ++i)
                vector[i] *= m;
        }

        public void Divide(int d)
        {
            if (d == 0)
                throw new DivideByZeroException();
            for (int i = 0; i < vector.Length; ++i)
                vector[i] /= d;
        }

        public void Print(int idx)
        {
            if (idx >= vector.Length)
                throw new IndexOutOfRangeException();
            Console.WriteLine($"Vector {idx} element: {vector[idx]}");
        }

        public void Print()
        {
            foreach(var item in vector)
                Console.WriteLine( item.ToString() );
        }
    }
}
