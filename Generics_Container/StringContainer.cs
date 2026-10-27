using System;

namespace Generics_Container
{
    public class StringContainer : Container<string>
    {
        public void PrintAllUpper()
        {
            foreach (string item in items)
            {
                Console.WriteLine(item?.ToUpper());
            }
        }
    }
}