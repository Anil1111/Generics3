using System;

class GenericClass<T>
        {
            public GenericClass(T msg)
            {
                Console.WriteLine(msg);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                GenericClass<string> gen = new GenericClass<string>("This is My generic class");
        GenericClass<double> getd = new GenericClass<double>(110.5);
        GenericClass<bool> getB = new GenericClass<bool>(true);
        GenericClass<int> getI = new GenericClass<int>(101);
        GenericClass<char> getCh = new GenericClass<char>('I');
        
                
            }
        }
