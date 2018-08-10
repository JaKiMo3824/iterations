using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterations
{
    class Program
    {
        static void Main(string[] args)
        {
        
            
            //1) Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each string in the array, adding the user's text to the string. Then creat a loop that prints off each string in the Array on a separate line.

            string[] userArray = new string[5];


            for (int i = 0; i < userArray.Length; i++)
            {

                Console.WriteLine("Please type in a Last Name");
                userArray[i] = Console.ReadLine();


            }

            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine(userArray[i]);
            }

            Console.ReadLine();

            //2) Create an infinite loop.

            List<int> intList = new List<int>();
            int i = 0;
            while (1 < 2)
            {


                    intList.Add(i = i + 1);
                    intList.ForEach(Console.WriteLine);

            }
            Console.ReadLine();


            //3) Fix the infinite loop so it will execute

            List<int> intList = new List<int>(10);
            int i = 0;
            while (i < 10)
            {


                intList.Add(i = i + 1);
                intList.ForEach(Console.WriteLine);

            }
            Console.ReadLine();

            //4)Create a loop where the comparison used to determine whether to continue iterating the loop is a "<" operator

            List<int> intList = new List<int>(10);
            int i = 0;
            while (i < 10)
            {


                intList.Add(i = i + 1);
                intList.ForEach(Console.WriteLine);

            }
            Console.ReadLine();

            

            //5) Create a loop where the comparison used to determine whether to continue iterating the loop is a "<=> operator.

            List<int> intList = new List<int>(10);
            int i = 0;
            while (i <= 10)
            {


                intList.Add(i = i + 1);
                intList.ForEach(Console.WriteLine);

            }
            Console.ReadLine();
            

            //6) Create a list of strings where each item in the list is unique.  Ask the user to selet text to search for in the List. Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.

            List<string> stringUnique = new List<string>();
            stringUnique.Add("tiger");
            stringUnique.Add("lion");
            stringUnique.Add("bear");
            stringUnique.Add("elephant");
            stringUnique.Add("hippo");
            stringUnique.Add("giraffe");
            stringUnique.Add("monkey");
            stringUnique.Add("parrot");
            stringUnique.Add("shark");

            Console.WriteLine("Please type any letter(s)...");
            string userInput = Console.ReadLine();

            for (int i = 0; i < stringUnique.Count; i++)
            {
                if (stringUnique[i].Contains(userInput))
                {
                    Console.WriteLine(i.ToString() + ", " + stringUnique[i]);
                }
                

                
            }
            Console.ReadLine();
            
            //7) add code to that above loop that tells a user if they put in text that isn't in the List

            List<string> stringUnique = new List<string>();
            stringUnique.Add("tiger");
            stringUnique.Add("lion");
            stringUnique.Add("bear");
            stringUnique.Add("elephant");
            stringUnique.Add("hippo");
            stringUnique.Add("giraffe");
            stringUnique.Add("monkey");
            stringUnique.Add("parrot");
            stringUnique.Add("shark");

            Console.WriteLine("Please type any letter(s)...");
            string userInput = Console.ReadLine();

            for (int i = 0; i < stringUnique.Count; i++)
            {
                if (stringUnique[i].Contains(userInput))
                {
                    Console.WriteLine(i.ToString() + ", " + stringUnique[i]);
                }
            }
            bool results =  (stringUnique[0].Contains(userInput) || stringUnique[1].Contains(userInput) || stringUnique[2].Contains(userInput) || stringUnique[3].Contains(userInput) || stringUnique[4].Contains(userInput) || stringUnique[5].Contains(userInput) || stringUnique[6].Contains(userInput) || stringUnique[7].Contains(userInput) || stringUnique[8].Contains(userInput));
            
                if (results == false)
                    {
                    Console.WriteLine("Your search found 0 results...");
                    }


            
            Console.ReadLine();
            
            //8) Add code to that above loop that stops it from executing once a match has been found

            List<string> stringUnique = new List<string>();
            stringUnique.Add("tiger");
            stringUnique.Add("lion");
            stringUnique.Add("bear");
            stringUnique.Add("elephant");
            stringUnique.Add("hippo");
            stringUnique.Add("giraffe");
            stringUnique.Add("monkey");
            stringUnique.Add("parrot");
            stringUnique.Add("shark");

            Console.WriteLine("Please type any letter(s)...");
            string userInput = Console.ReadLine();

            for (int i = 0; i < stringUnique.Count; i++)
            {
                if (stringUnique[i].Contains(userInput))
                {
                    Console.WriteLine(i.ToString() + ", " + stringUnique[i]);
                    break;
                }
            }
            bool results = (stringUnique[0].Contains(userInput) || stringUnique[1].Contains(userInput) || stringUnique[2].Contains(userInput) || stringUnique[3].Contains(userInput) || stringUnique[4].Contains(userInput) || stringUnique[5].Contains(userInput) || stringUnique[6].Contains(userInput) || stringUnique[7].Contains(userInput) || stringUnique[8].Contains(userInput));

            if (results == false)
            {
                Console.WriteLine("Your search found 0 results...");
            }



            Console.ReadLine();
            

            //9) create a list of strings that has at least two identical strings in the List.  Ask the user to select text to search for in the list.  create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen


            List<string> stringUnique = new List<string>();
            stringUnique.Add("tiger");
            stringUnique.Add("tiger");
            stringUnique.Add("bear");
            stringUnique.Add("elephant");
            stringUnique.Add("hippo");
            stringUnique.Add("giraffe");
            stringUnique.Add("monkey");
            stringUnique.Add("parrot");
            stringUnique.Add("shark");

            Console.WriteLine("Please type any letter(s)...");
            string userInput = Console.ReadLine();

            for (int i = 0; i < stringUnique.Count; i++)
            {
                if (stringUnique[i].Contains(userInput))
                {
                    
                    Console.WriteLine(i.ToString() + ", " + stringUnique[i]);
                }
            }
            bool results = (stringUnique[0].Contains(userInput) || stringUnique[1].Contains(userInput) || stringUnique[2].Contains(userInput) || stringUnique[3].Contains(userInput) || stringUnique[4].Contains(userInput) || stringUnique[5].Contains(userInput) || stringUnique[6].Contains(userInput) || stringUnique[7].Contains(userInput) || stringUnique[8].Contains(userInput));

            if (results == false)
            {
                Console.WriteLine("Your search found 0 results...");
            }



            Console.ReadLine();
            
            //10) add code to that above loop that tells a user if they put in text that isnt in the list

            List<string> stringUnique = new List<string>();
            stringUnique.Add("tiger");
            stringUnique.Add("tiger");
            stringUnique.Add("bear");
            stringUnique.Add("elephant");
            stringUnique.Add("hippo");
            stringUnique.Add("giraffe");
            stringUnique.Add("monkey");
            stringUnique.Add("parrot");
            stringUnique.Add("shark");

            Console.WriteLine("Please type any letter(s)...");
            string userInput = Console.ReadLine();

            for (int i = 0; i < stringUnique.Count; i++)
            {
                if (stringUnique[i].Contains(userInput))
                {

                    Console.WriteLine(i.ToString() + ", " + stringUnique[i]);
                }
            }
            bool results = (stringUnique[0].Contains(userInput) || stringUnique[1].Contains(userInput) || stringUnique[2].Contains(userInput) || stringUnique[3].Contains(userInput) || stringUnique[4].Contains(userInput) || stringUnique[5].Contains(userInput) || stringUnique[6].Contains(userInput) || stringUnique[7].Contains(userInput) || stringUnique[8].Contains(userInput));

            if (results == false)
            {
                Console.WriteLine("Your search found 0 results...");
            }



            Console.ReadLine();
            
            //11) create a list of strings that has at least two identical strings in the list. create a foreach loop that evaluates each item in the list and displays a message showing the string and whether or not it has already appeared in the list
            
            List<string> stringUnique = new List<string>();
            stringUnique.Add("tiger");
            stringUnique.Add("lion");
            stringUnique.Add("bear");
            stringUnique.Add("elephant");
            stringUnique.Add("hippo");
            stringUnique.Add("hippo");
            stringUnique.Add("monkey");
            stringUnique.Add("monkey");
            stringUnique.Add("shark");

            
            var hashset = new HashSet<string>();

            foreach (string unique in stringUnique)
            {
                if (!hashset.Add(unique))
                {
                    Console.WriteLine(unique + " is a duplicate.");
                    
                }

                

            }
            Console.ReadLine();



            

    








































        }   

        
        

        
    }
}
