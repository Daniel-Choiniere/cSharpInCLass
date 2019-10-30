using System;

namespace defangIP
{
    class Program
    {
        static string DefangIPaddr(string address) 
        {
            return address.Replace(".", "[.]");
        
        }
        
        public static void Main(string[] args)
        {
            string address = "1.1.1.1";
            Console.WriteLine(DefangIPaddr(address));
        }
    }
}
