using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PrvaDz
{
    class Program
    {
        static void Main(string[] args)
        {
            IIntegerList list = new IntegerList();
            ListExample(list);
            ReadLine();
        }

        public static void ListExample(IIntegerList listOfIntegers)
        {
            listOfIntegers.Add(1); // [1] 
            listOfIntegers.Add(2); // [1,2] 
            listOfIntegers.Add(3); // [1,2,3] 
            listOfIntegers.Add(4); // [1,2,3,4] 
            listOfIntegers.Add(5); // [1,2,3,4,5]
            listOfIntegers.RemoveAt(0); // [2,3,4,5] 
            listOfIntegers.Remove(5); //[2,3,4]
            WriteLine(listOfIntegers.Count); // 3 
            WriteLine(listOfIntegers.Remove(100)); // false 
            WriteLine(listOfIntegers.RemoveAt(5)); // false 
            listOfIntegers.Clear(); // [] 
            WriteLine(listOfIntegers.Count); // 0
        }

    }
}
