using System.Drawing;
using System.Numerics;
using System.Reflection.Metadata;

namespace C_Avanced03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region (Q1) Student Grade Manager

            // 1. Create a Collection with these grades
            //Console.WriteLine("-------Elements-------------");
            //List<int> grades = new List<int>()
            //{
            //    85,92,78,95,88,70,100, 65
            //};

            //// 2. Print the collection, Count, first and last grade
            //foreach (int grade in grades) 
            //{
            //    Console.WriteLine(grade); 
            //}

            //Console.WriteLine($"Grades Count:{grades.Count}" );
            //Console.WriteLine($"First element:{grades[0]}");
            //Console.WriteLine($"Last element:{grades.Last<int>()}");

            //// 3. Sort the grades ascending, then print

            //Console.WriteLine("\n-------SortedElements(ascendingly)-------------");
            //grades.Sort();
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}

            //// 4. Get the first grade above 90
            //int FirstGradeAbove90 = grades.Find(g => g > 90);
            //Console.WriteLine($"\nFirst Grade above 90 is {FirstGradeAbove90}\n");

            //// 5. Get all grades below 75 (failing grades)
            //Console.WriteLine("-------Grades below 75-------------");
            //List<int> FailingGrades = grades.FindAll(g => g < 75);
            //foreach (int grade in FailingGrades) { Console.WriteLine(grade); }

            //// 6. Remove all failing grades (below 75)
            //Console.WriteLine("-------Remove Grades below 75-------------");
            //grades.RemoveAll(g => g < 75);
            //foreach (int grade in grades) { Console.WriteLine(grade); }

            //// 7. Check if any grade equals 100
            //bool check= grades.Contains(100);
            //Console.WriteLine($"\ndid the list contains 100: {check}");

            //// 8.Create a List<string> where each grade becomes "Grade: X"
            //Console.WriteLine("\n------List Grades in string----------");
            //List<string> GradeStrings = grades.Select(g => $"Grades:{g.ToString()}").ToList();
            //foreach(string gradeString in GradeStrings) { Console.WriteLine(gradeString); }

            #endregion

            #region (Q2) Leaderboard

            //// 1 Add entries (SortedDictionary sorts by score automatically)
            //SortedDictionary<int, string> PlayersScore = new SortedDictionary<int, string>()
            //{
            //    { 500 , "Ahmed" },
            //    { 200 , "Sara" },
            //    { 800 , "Ali" },
            //    { 350 , "Mona" }
            //};

            //// 2. Print all entries
            //foreach (var Player in PlayersScore) { Console.WriteLine($"Score: {Player.Key} -> Player: {Player.Value}"); }

            //// 3. Access the first key and first value explicitly
            //Console.WriteLine($"\nFirst element in sortedDictionary is {PlayersScore.First()}");

            //// 4. Check if score 500 exists
            //bool checkKey = PlayersScore.ContainsKey(500);
            //Console.WriteLine($"\ndid the sorted dictionary has key 500: {checkKey}");

            //// 5. Safely get the player with score 999
            //bool GetValuebyKey = PlayersScore.TryGetValue(999, out string? result);
            //Console.WriteLine($"\ndid the Player who Scores 999 exist: {GetValuebyKey}");

            //// 6. Remove the player with score 200 and print the updated list
            //Console.WriteLine("\n----After removing key 200 --------");
            //PlayersScore.Remove(200);
            //foreach (var Player in PlayersScore)
            //{
            //    Console.WriteLine(Player);
            //}

            #endregion

            #region (Q3) Phone Book

            // Dictionary<string, string> Contacts = new Dictionary<string, string>();

            // // 1. Create a Collection with 4 contacts (name -> phone number)
            // // 2. Add a new contact using [] syntax (add or update)
            // Contacts["Sara"] = "0111222333";
            // Contacts["Ali"] = "01222333444";
            // Contacts["Ahmed"] = "01333444555";
            // Contacts["Mona"] = "01444555666";

            // // 3. Try adding a duplicate using .Add() - catch the exception and print the error
            // try
            // {
            //     Contacts.Add("Sara", "0111222333");
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine($"Error: {ex.Message}");
            // }

            // // 4. Try adding a duplicate using .TryAdd() - print whether it succeeded
            // Console.WriteLine($"TryAdd succeeded?{Contacts.TryAdd("Ahmed", "01333444555")}");

            // // 5. Search for a contact that doesn't exist
            //Console.WriteLine("------Search for contact-------");
            //bool check= Contacts.ContainsKey("Laila");
            //Console.WriteLine($"Does Laila exist? {check}");

            // // 6. Get a contact with a fallback of "Not Found"
            // Console.WriteLine(Contacts.GetValueOrDefault("Laila", "Not Found"));

            // // 7. Print all Keys on one line, then all Values on another line
            // Console.WriteLine("\n-----Contacts--------");
            // foreach (var key in Contacts.Keys)
            // {
            //     Console.WriteLine($"Name: {key}");
            // }

            // foreach (var value in Contacts.Values)
            // {
            //     Console.WriteLine($"Phone Number: {value}");
            // }


            #endregion

            #region (Q4) Unique Email Validator

            //// 1 & 2 HashSet with case-insensitive comparer
            //HashSet<string> set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //set.Add("ahmed@test.com");
            //set.Add("AHMED@test.com");
            //set.Add("sara@test.com");
            //set.Add("Sara@Test.Com");

            ////3. Print Count — how many are actually stored? Explain why. 
            //Console.WriteLine($"How Many Emails Stored: {set.Count}");
            //// Because Hashset store only unique numbers not duplicated ones and here we ignore case sensitive.

            ////4. Create two sets: Set A = {1,2,3,4,5} and Set B = {4,5,6,7,8} 
            //HashSet<int> A = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> B = new HashSet<int> { 4, 5, 6, 7, 8 };

            ////5. Print the result of: UnionWith, IntersectWith, ExceptWith 
            //Console.WriteLine("\n-------Union with--------\n");
            //HashSet<int> union = new HashSet<int>(A);
            //union.UnionWith(B);
            //foreach(int u in union) {Console.WriteLine($"UnionWith Result:{u}"); }

            //Console.WriteLine("\n-------Intersect with--------\n");
            //HashSet<int> Intersect = new HashSet<int>(A);
            //Intersect.IntersectWith(B);
            //foreach(int x in Intersect) {Console.WriteLine($"IntersectWith Result:{x}"); }

            //Console.WriteLine("\n-------Except with--------\n");
            //HashSet<int> Except = new HashSet<int>(A);
            //Except.ExceptWith(B);
            //foreach(int e in Except) {Console.WriteLine($"ExceptWith Result:{e}");}

            ////6. Use IsSubsetOf to check if {1,2} is a subset of Set A
            //Console.WriteLine("\n-------Subset of--------\n");
            //HashSet<int> c= new HashSet<int> { 1, 2 };
            //Console.WriteLine($"Is [1,2] subset of A:{c.IsSubsetOf(A)}");



            #endregion

            #region (Q5) Print Queue Simulator 

            //Queue<string> queue=new Queue<string>();

            //queue.Enqueue("Report.pdf");
            //queue.Enqueue("Invoice.pdf");
            //queue.Enqueue("Letter.docx");
            //queue.Enqueue("Resume.pdf");
            //queue.Enqueue("Photo.jpg");

            //// 2.Use Peek to see which document will print next(without removing)
            //Console.WriteLine("----------Queue elements----------");
            //foreach (var item in queue) { Console.WriteLine(item); }

            //Console.WriteLine($"\nHow Many elements in Queue:{queue.Count}");

            //// 2. Use Peek to see which document will print next (without removing)
            //Console.WriteLine($"\nTop element:{queue.Peek()}");

            //// 3. Process the queue: Dequeue each document and print "Printing: [name]"
            //Console.WriteLine("\n---------Processing Queue(Dequeue)---------");
            //while (queue.Count > 0)
            //{
            //    string doc = queue.Dequeue();
            //    Console.WriteLine($"Printing: [{doc}]");
            //}

            //// 4.Try TryDequeue on the now-empty queue - what happens?
            //Console.WriteLine($"\nIs Queue Contain elements: {queue.TryDequeue(out string? result)}");

            #endregion

            #region (Q6) Browser History (Undo) 

            // Create a Stack<string> for browser history and push 5 URLs
            Stack<string> stack = new Stack<string>();

            stack.Push("google.com");
            stack.Push("github.com");
            stack.Push("stackoverflow.com");
            stack.Push("youtube.com");
            stack.Push("claude.ai");

            //2. Use Peek to see the current page (top of stack) 
            Console.WriteLine($"Top page in stack:{stack.Peek()}");

            //3. Press "back" 3 times using Pop — print each page you leave
            Console.WriteLine("\n--------process pop 3 times--------");
            for (int i = 0; i < 3; i++)
            {
                string Page = stack.Pop();
                Console.WriteLine($"Leaving page: {Page}");
            }

            //4. Print the current page after going back 
            Console.WriteLine($"\nCurrent Page: {stack.Peek()}\n");

            //5. Try TryPop on an empty stack — what happens?
            Console.WriteLine($"is stack contain elements:{stack.TryPop(out string? result)}");
            //it will return true because there still pages we only pop 3 pages out of 5 pages


            #endregion
        }
    }
}
