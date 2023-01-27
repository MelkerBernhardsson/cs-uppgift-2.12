using System;

namespace uppgift212
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("att hyra en bil kostar 500kr per dag, hur många dagar ska du hyra?");
            int tid = int.Parse(Console.ReadLine());
            Console.WriteLine("det kommer att kosta en kr kilometern, hur långt ska du köra? ( i km )");
            int distans = int.Parse(Console.ReadLine());
            int pris = (tid * 500) + distans - 500 + 300;
            Console.WriteLine("den totala kostnaden för att hyra bilen i "+ tid +" dagar blir: " + pris);
        }
    }
}
