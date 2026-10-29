using System.Numerics;

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

            Dictionary<string, string> Contacts = new Dictionary<string, string>();

            // 1. Create a Collection with 4 contacts (name -> phone number)
            // 2. Add a new contact using [] syntax (add or update)
            Contacts["Sara"] = "0111222333";
            Contacts["Ali"] = "01222333444";
            Contacts["Ahmed"] = "01333444555";
            Contacts["Mona"] = "01444555666";

            // 3. Try adding a duplicate using .Add() - catch the exception and print the error
            try
            {
                Contacts.Add("Sara", "0111222333");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // 4. Try adding a duplicate using .TryAdd() - print whether it succeeded
            Console.WriteLine($"TryAdd succeeded?{Contacts.TryAdd("Ahmed", "01333444555")}");

            // 5. Search for a contact that doesn't exist
           Console.WriteLine("------Search for contact-------");
           bool check= Contacts.ContainsKey("Laila");
           Console.WriteLine($"Does Laila exist? {check}");

            // 6. Get a contact with a fallback of "Not Found"
            Console.WriteLine(Contacts.GetValueOrDefault("Laila", "Not Found"));

            // 7. Print all Keys on one line, then all Values on another line
            Console.WriteLine("\n-----Contacts--------");
            foreach (var key in Contacts.Keys)
            {
                Console.WriteLine($"Name: {key}");
            }

            foreach (var value in Contacts.Values)
            {
                Console.WriteLine($"Phone Number: {value}");
            }


            #endregion
        }
    }
}
