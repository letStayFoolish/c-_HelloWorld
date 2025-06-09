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

            string friends = $"My friends are {firstName} and Someone else";
            Console.WriteLine(friends);
            Console.WriteLine(friends.Replace("Nemanja", "Anja"));
            Console.WriteLine(friends);
            Console.WriteLine(friends.StartsWith("Are they"));

            int capacity = friends.Split(" ").Length;
            for (int j = 0; j < capacity; j++)
            {
                Console.WriteLine($"Looping: {j}/{capacity}");
            }

            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"Row: {row}, Column: {column}");
                }
            }

            var teaList = new List<string> { "Black", "Green", "White" };

            teaList.Add("Macha");

            // for-loop vs. foreach-loop
            for (int j = 0; j < teaList.Count; j++)
            {
                Console.WriteLine(teaList[j].ToUpper());
            }

            foreach (var tea in teaList)
            {
                Console.WriteLine($"My favorite tea is {tea}");
            }

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
                int convertedStr = Convert.ToInt32(numberAsStr);
                // int convertedStr = Convert.ToByte(numberAsStr);
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

            var numberA = 2;
            var numberB = 9;

            Console.WriteLine((float)numberB / (float)numberA);

            // Standard declaration
            string[] names = new string[3];
            names[0] = "Nemanja";
            names[1] = "Irina";
            names[2] = "Jelena";

            // Declaration with initialization
            string[] myNewList = { "C#", "Java", "JavaScript" };
            Console.WriteLine(myNewList);
            foreach (var name in names)
            {
                Console.WriteLine($"Name: {name}");
            }

            // LINQ
            List<int> scores = [1, 55, 6, 77, 223, 43];
            // LINQ Query Expression
            // it is LIKE SQL - it is a Language Integrated Query
            IEnumerable<string> scoresQuery =
                // query syntax
                from score in scores
                where score > 44
                orderby score descending
                select $"The score is: {score}";
            // SQL
            foreach (var score in scoresQuery)
            {
                Console.WriteLine(score);
            }

            Random random = new Random();
            string[] orders = new string[7];
            for (var c = 0; c < orders.Length; c++)
            {
                int prefixNumber = random.Next(65, 70);
                string prefixLetter = Convert.ToChar(prefixNumber).ToString();
                string suffixNumber = random.Next(1, 1000).ToString("000");

                string id = $"{prefixLetter}{suffixNumber}";
                orders[c] = id;
            }

            foreach (string order in orders)
            {
                Console.WriteLine($"Order ID: {order}");
            }

            // Student Grade Challenge
            int examAssignments = 5;
            
            int[] sophiasGrades = new int[] { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewGrades = new int[] { 92, 89, 81, 96, 90, 89 };
            int[] emmaGrades = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganGrades = new int[] { 90, 95, 87, 88, 96, 96 };

            string[] studentNames = new[] { "Sophia", "Andrew", "Emma", "Logan" };

            int[] studentScores = new int[10];

            Console.WriteLine("Student\t\tGrade\n");

            foreach (string name in studentNames)
            {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                {
                    studentScores = sophiasGrades;
                }
                else if (name == "Andrew")
                {
                    studentScores = andrewGrades;
                }
                else if (name == "Emma")
                {
                    studentScores = emmaGrades;
                }
                else if (name == "Logan")
                {
                    studentScores = loganGrades;
                }

                int sumAssignmentScores = 0;
                decimal currentStudentGrade = 0;
                string currentStudentLetterGrade = "";
                int gradedAssignments = 0;

                foreach (var score in studentScores)
                {
                    gradedAssignments++;

                    if (gradedAssignments <= examAssignments)
                    {
                        sumAssignmentScores += score;
                    }
                    else
                    {
                        sumAssignmentScores += score / 10;
                    }
                }

                currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;
                
                if (currentStudentGrade  >= 97)
                {
                    currentStudentLetterGrade = "A+";
                }
                else if (currentStudentGrade >= 93)
                {
                    currentStudentLetterGrade = "A";
                }
                else if (currentStudentGrade >= 90)
                {
                    currentStudentLetterGrade = "A-";
                }
                else if (currentStudentGrade >= 87)
                {
                    currentStudentLetterGrade = "B+";
                }
                else if (currentStudentGrade >= 83)
                {
                    currentStudentLetterGrade = "B";
                }
                else if (currentStudentGrade >= 80)
                {
                    currentStudentLetterGrade = "B-";
                }
                else if (currentStudentGrade >= 77)
                {
                    currentStudentLetterGrade = "C+";
                }
                else if (currentStudentGrade >= 73)
                {
                    currentStudentLetterGrade = "C";
                }
                else if (currentStudentGrade >= 70)
                {
                    currentStudentLetterGrade = "C-";
                }
                else if (currentStudentGrade >= 67)
                {
                    currentStudentLetterGrade = "D+";
                }
                else if (currentStudentGrade >= 63)
                {
                    currentStudentLetterGrade = "D";
                }
                else if (currentStudentGrade >= 60)
                {
                    currentStudentLetterGrade = "D-";
                }
                else
                {
                    currentStudentLetterGrade = "F";
                }

                Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
            }

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
        }
    }
}