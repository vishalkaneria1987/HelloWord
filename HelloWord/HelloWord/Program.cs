using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    [TestClass]
    public class Program
    {
        [TestMethod]
        public static void Main(String[] arg)
        {
            Console.WriteLine(CreateMessage());
        }
        public static string CreateMessage()
        {
            return "HelloWord";
        }

    }
}