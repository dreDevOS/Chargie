using System;

namespace Chargie
{
    public class chargie
    {

        public string name;
        public char gender;
        public int age;



        public chargie() {
            name = "andre";
        
        }




        static void Main(string[] args)
        {
            chargie friend = new chargie();

            Console.WriteLine(friend.name);
        }
    }





    
}
