// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

// namespace HelloWorld
// {
//     internal abstract class Program
//
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello, World!"); // read data from console or write data to console
//         }
//     }
// };

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte number = 2;
            // int count = 10;
            // float totalPrice = 22.5f;
            // char letter = 'a';
            // string firstName = "Nemanja";
            // bool isWorking = true;
            
            var number = 2;
            var count = 10;
            var totalPrice = 22.5f;
            var letter = 'a';
            var firstName = "Nemanja";
            var isWorking = true;

            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            int intNum = 4;
            byte byteNum = (byte)intNum;
            Console.WriteLine(byteNum);

            try
            {
                var numberAsStr = "1234";
                // int convertedStr = numberAsStr; // won't work!
                // int convertedStr = Convert.ToInt32(numberAsStr);
                int convertedStr = Convert.ToByte(numberAsStr);
                Console.WriteLine(numberAsStr);
                Console.WriteLine(convertedStr);
            }
            catch (Exception e)
            {
                Console.WriteLine("The number could not be converted to a byte!");
                Console.WriteLine(e);
                throw;
            }
            
            
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(letter);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            // Console.WriteLine(); // code snippet: "cw"
            Console.WriteLine("{0} {1} {2}", byte.MinValue, byte.MaxValue, totalPrice);
        }
    }
}