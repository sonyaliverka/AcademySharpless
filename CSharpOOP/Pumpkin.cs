using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public class Pumpkin
    {
        public string Nane;
        public int Age;
        public string Color;
        public bool HasTail;

        public void CheckAge()
        {
            if(Age>18)
            {
                Console.WriteLine("Too old");

            }
            else if(Age<18)
            {
                Console.WriteLine("Too young");
            } 
            else
            {
                Console.WriteLine("Good");
            }

        }
    }

}
