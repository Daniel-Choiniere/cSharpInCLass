using System;

namespace defangIP
{
    class Program
    {
        static string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        
        }
//        {
//            for (var i = 0; i < address.Length; i++)
//            {
//                if (address[i] == '.')
//                {
//                    address.Insert(i - 1, "[");
//                    address.Insert(i + 1, "]");
//                }
//            }
//
//            return address;
//        }
        
        public static void Main(string[] args)
        {
            string address = "1.1.1.1";
            Console.WriteLine(DefangIPaddr(address));
        }
    }
}
