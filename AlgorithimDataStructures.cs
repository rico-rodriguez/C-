namespace _04_AlgorithmDataStructures_01_Starter
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("04 -> Algorithms and Data Structures");

            // #TODO: Task 1.2 Create an array here called gradesArray
            double[] gradesArray = { 89.2, 78.4, 95.2, 89.14, 89.3 };

            // #TODO: Task 1.3 Call the addGrades method, passing it the gradesArray
            addGrades(gradesArray);

            // #TODO: Task 1.4 After adding grades to the array, call the displayGrades method
            // to print out the grades to the console window
            // Use the foreach construct to iterate over the array

            displayGrades(gradesArray);

            // #TODO: Task 2.1 Create a new Stack object called myStack
            Stack<double> myStack = new();

            // #TODO: Task 2.2 Call the pushStack() method passing in the grades array for values
            pushStack(gradesArray, myStack);
            //Console.WriteLine("Stack peek =  " + myStack.Peek());
            //Console.WriteLine("Stack count =  " + myStack.Count());

            // #TODO: Task 2.4 Call the popStack() method twice to remove the top two items from stack
            // The popStack method will display each popped item to the console window
            popStack(myStack);
            popStack(myStack);
            Console.WriteLine("Stack count =  " + myStack.Count());


            // #TODO: Task 3.1 Create a new SortedList object called myCourses
            SortedList<string, string> myCourses = new SortedList<string, string>();


            // #TODO: Task 3.2 Call the populateList() method

            populateList(myCourses);
            Console.WriteLine("Courses count: " + myCourses.Count);


            // #TODO: Task 3.3 display a course in the list by passing a key

            DisplayList(myCourses, "CS02");


            // #TODO: Task 3.4 Remove an item from the myCourses list using the key
            removeListItem(myCourses, "CS02");


        }


        static void addGrades(double[] grdArray)
        {

        }

        static void displayGrades(double[] grdArray)
        {
            foreach (var grade in grdArray)
            {
                Console.WriteLine(grade);

            }
        }

        public static Stack<double> pushStack(double[] grdArray, Stack<double> myStack)
        {
            foreach (var x in grdArray)
            {
                myStack.Push(x);
            }
            return myStack;
        }

        static Stack<double> popStack(Stack<double> myStack)
        {
            double popped = myStack.Pop();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Item removed from the stack: " + popped);
            Console.ForegroundColor = ConsoleColor.White;
            return myStack;


        }

        static SortedList<string, string> populateList(SortedList<string, string> list)
        {
            list.Add("CS01", "Comp Sci 1");
            list.Add("CS02", "Comp Sci 2");
            list.Add("CS03", "Comp Sci 3");
            list.Add("CS04", "Comp Sci 4");

            return list;
        }

        static void DisplayList(SortedList<string, string> myCourses, string key)
        {

            if (myCourses.ContainsKey(key))
            {
                Console.WriteLine(myCourses[key]);
            }
        }
        static SortedList<string, string> removeListItem(SortedList<string, string> myCourses, string key)
        {

            if (!myCourses.ContainsKey(key))
            {
                Console.WriteLine($"Key \"{key}\" is not found.");
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nRemoved (\"{key}\") from list.");
                myCourses.Remove(key);
                Console.ForegroundColor = ConsoleColor.White;

            }
            return myCourses;

        }
    }
}
