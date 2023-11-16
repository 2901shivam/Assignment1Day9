using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Day9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LargeDataCollection Largedata = new LargeDataCollection(new List<object>() { 1, "Shiv", true, 12.4 });
            Console.WriteLine("Data at index :"+Largedata.getElement(-1));
            Largedata.Add(5);
            Largedata.Remove(1);
            Largedata.print();

            Largedata.Dispose();
        }
    }
}
