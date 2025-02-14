namespace MAAT04.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Integer data type is generally   
            //// used for numeric values
            //int i = 89;

            //short s = 56;

            //// this will give error as number
            //// is larger than short range
            //// short s1 = 87878787878;

            //// long uses Integer values which 
            //// may signed or unsigned
            //long l = 4564;

            //// UInt data type is generally
            //// used for unsigned integer values
            //uint ui = 95;

            //ushort us = 76;
            //// this will give error as number is
            //// larger than short range

            //// ulong data type is generally
            //// used for unsigned integer values
            //ulong ul = 3624573;

            //// by default fraction value
            //// is double in C#
            //double d = 8.358674532;

            //// for float use 'f' as suffix
            //float f = 3.7330645f;

            //// for float use 'm' as suffix
            //decimal dec = 389.5m;

            //Console.WriteLine("integer: " + i);
            //Console.WriteLine("short: " + s);
            //Console.WriteLine("long: " + l);
            //Console.WriteLine("float: " + f);
            //Console.WriteLine("double: " + d);
            //Console.WriteLine("decimal: " + dec);
            //Console.WriteLine("Unsinged integer: " + ui);
            //Console.WriteLine("Unsinged short: " + us);
            //Console.WriteLine("Unsinged long: " + ul);

            //char c = 'a';
            //char cUnicode = '\u0061';
            //char cEscape = '\n';

            //Console.WriteLine("Char: " + c);
            //Console.WriteLine("Char Unicode: " + cUnicode);
            //Console.WriteLine("Char Escape: " + cEscape);
            //Console.WriteLine("Char Tab: \t\tTab");
            //Console.WriteLine("Char Tab 2: \t\tTab 2");
            //Console.WriteLine("Il mio nome é \"Alessio\"");

            //bool bTrue = true;
            //bool bFalse = false;

            //Console.WriteLine("Bool true: " + bTrue);
            //Console.WriteLine("Bool false: " + bFalse);

            //string strNullable = null;
            //Console.WriteLine("String Nullable: " + strNullable);

            /////////////////////////////
            /// STRING CONCATENATION ///
            ///////////////////////////

            string? name = Console.ReadLine();
            string? lastname = Console.ReadLine();

            Console.WriteLine("Hello " + name + " " + lastname);
            Console.WriteLine("Hello {0} {1}", name, lastname);

            string welcomeMessage = "Hello " + name + " " + lastname;
            string welcomeMessage2 = string.Format("Hello {0} {1}", name, lastname);
            string welcomeMessage3 = $"Hello {name} {lastname}";

            Console.WriteLine(welcomeMessage);
            Console.WriteLine(welcomeMessage2);
            Console.WriteLine(welcomeMessage3);

            int? iNullable = null;
            Console.WriteLine("Integer Nullable: " + iNullable);

            object obj1 = 5;
            object obj2 = "5";
            object obj3 = true;

            Console.WriteLine(obj1.Equals(obj2));
            Console.WriteLine("obj1: " + obj1.ToString());
            Console.WriteLine("obj2: " + obj2.ToString());
            Console.WriteLine("obj3: " + obj3.ToString());

            var firstName = "Alessio";
            var num1 = 5;
            var isActive = false;
        }
    }
}
