using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PrvaDz_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            IGenericList<string> stringList = new GenericList<string>();
            // ListExample(stringList);
            stringList.Add("Hello");
            stringList.Add("World");
            stringList.Add("!");
            foreach (string value in stringList)
            {
                 WriteLine(value); 
            }
            ReadLine();
        }

        public static void ListExample(IGenericList<string> list)
        {
            list.Add("1a");
            list.Add("2b"); 
            list.Add("3c"); 
            list.Add("4d"); 
            list.Add("5e"); 
            list.RemoveAt(0);
            list.Remove("5e");
            WriteLine(list.GetElement(2));
            WriteLine(list.Count); 
            WriteLine(list.Remove("100"));
            WriteLine(list.RemoveAt(5)); 
            list.Clear(); 
            WriteLine(list.Count); 
        }
    }
}
