using System;

namespace _013_NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x; //anulável
            Nullable<int> y; //anulável

            int z; //não anulável

            x = null;

            y = 10;

            Console.WriteLine(x);
            Console.WriteLine(y);
            
            if (x.HasValue)
                z = x.Value;
            else
                z = -1;

            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
