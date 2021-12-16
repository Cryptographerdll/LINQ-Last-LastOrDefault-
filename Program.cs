using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace LINQ_Last_Or_Default
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "IronMan", "SuperMan", "BatMan", "SpiderMan", "Bora" };

            var FirstItem = Names.LastOrDefault(a => a.StartsWith("S")); // Bora 

            #region comment 
            // In Last(); method we get the last item in string List .
            // In case we Give unexistant word Programm will Give Error console soo we must use theLastOrDefault(); Method .
            #endregion

            Console.Write(FirstItem); // Does not exist soo we ask the programm if not exist == Null return True . 
        }
    }
}
