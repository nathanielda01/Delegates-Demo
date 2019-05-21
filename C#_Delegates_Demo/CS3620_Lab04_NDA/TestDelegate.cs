
// Purpose: This program is created to show the functionality of delegates
// and all things concerning delegates. The program reads in inputs and
// randomly chooses a function through which to run them. The result is
// outputted as a string.

// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delegates_Demo
{
    /// <summary>
    /// This class takes inputs and runs them through a delegate that is randomly chosen to take input
    /// </summary>
    class TestDelegate
    {
        private List<Func<int, double, char, string, string>> _DList;

        /*  First attempt at some delegates, but I found out that they won't go into the Func List
        public delegate string SomeMethod(int T1, double T2, char T3, string T4);

        public SomeMethod print = (int a, double b, char c, string d) =>
            string.Format("Item {0}: {1:c}\tAisle {2}\tOne-Word Descrition: {3}.", a, b, char.ToUpper(c), d);
        public SomeMethod randomizer = Randomizer;
        public SomeMethod spacer = Spacer;
        public SomeMethod unspacer = delegate (int a, double b, char c, string d) { return string.Format("{0}{1}{2}{3}", a, b, char.ToString(c), d); };
        */

        /// <summary>
        /// Method to put spaces between every character inputted
        /// </summary>
        /// <param name="num">an int that was input by user</param>
        /// <param name="dec">a double that was input by user</param>
        /// <param name="letter">a char inputted by user</param>
        /// <param name="word">a string inputted by user</param>
        /// <returns>a string of all parameters with spaces between every char</returns>
        private static string Spacer(int num, double dec, char letter, string word)
        {
            string temp = num.ToString() + dec.ToString() + letter.ToString() + word;
            string result = "";
            for (int i = 0; i < temp.Length; i++)
            {
                result = result + temp[i].ToString() + " ";
            }
            return result;
        }

        /// <summary>
        /// Creates a random string composed of user input parameters
        /// </summary>
        /// <param name="numLetters">int that determines the number of letters</param>
        /// <param name="waitTime">supposed to rep how many seconds until output was revealed to user</param>
        /// <param name="startWith">the char that the randomized string would start with</param>
        /// <param name="lettersAvailabe">the letter pool that the randomizer had to choose from</param>
        /// <returns>a string composed of a certain number of chars that have been randomly generated</returns>
        private static string Randomizer(int numLetters, double waitTime, char startWith, string lettersAvailabe)
        {
            Random random = new Random();
            char[] lettArr = lettersAvailabe.ToCharArray();
            string result = startWith.ToString();
            for (int i = 0; i < numLetters - 1; i++)
            {
                int useLetter = random.Next(0, lettersAvailabe.Length);
                result += lettersAvailabe[useLetter];
            }
            return result;

        }

        /// <summary>
        /// checks input for vowels and if numbers divide by 2
        /// </summary>
        /// <param name="a">int inputted by user</param>
        /// <param name="b">double inputted by user</param>
        /// <param name="c">char inputted by user</param>
        /// <param name="d">string inputted by user</param>
        /// <returns>a string that will notify the user what has been found from their input</returns>
        private static string inChecker(int a, double b, char c, string d)
        {
            string result = "";
            Predicate<string> aFinder = (string s) => { return s.Contains("a"); };
            Predicate<string> eFinder = (string s) => { return s.Contains("e"); };
            Predicate<string> iFinder = (string s) => { return s.Contains("i"); };
            Predicate<string> oFinder = (string s) => { return s.Contains("o"); };
            Predicate<string> uFinder = (string s) => { return s.Contains("u"); };

            Predicate<int> divByTwo = (int i) => { return i % 2 == 0; };
            Predicate<double> doubleDivByTwo = (double dd) => { return dd % 2 == 0; };
            Predicate<string>[] sPredArr = { aFinder, eFinder, iFinder, oFinder, uFinder };
            int count = 0;
            foreach (Predicate<string> pred in sPredArr)
            {
                if (pred(d)) count++;
            }
            result += string.Format("Your word has {0} kind(s) of vowel(s).\n", count);
            foreach (Predicate<string> pred in sPredArr)
            {
                if (pred(c.ToString()))
                    result += "Your letter is a vowel.\n";
            }
            if (divByTwo(a))
                result += "Your number can divide by 2.\n";
            else result += "Your number cannot divide by 2.\n";
            if (doubleDivByTwo(b))
                result += "Your price can cleanly divide by 2.\n";
            else result += "Your price cannot divide by 2.\n";
            return result;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public TestDelegate()

        {
            // _DList is the same as a list of functions 
            // with params (int a, double b, char c, string d)
            // it then returns a string
            _DList = new List<Func<int, double, char, string, string>>();

            // Add private methods and lambdas if output is simpler
            _DList.Add(Randomizer);
            _DList.Add(Spacer);
            _DList.Add(
                (int a, double b, char c, string d) =>
                string.Format("Item {0}: {1:c}\tAisle {2}\tOne-Word Description: {3}.", a, b, char.ToUpper(c), d)
            );
            _DList.Add(
                (int a, double b, char c, string d) =>
                a.ToString() + b.ToString() + c.ToString() + d
            );
            _DList.Add(inChecker);

        }

        /// <summary>
        /// Calls a func randomly from _DList to run input through
        /// </summary>
        /// <returns>
        /// The Func that was randomly chosen
        /// </returns>
        private Func<int, double, char, string, string> CallFunc()
        {
            Random random = new Random();
            return _DList[random.Next(0, _DList.Count)];
        }

        /// <summary>
        /// runs params through CallFunc() method and returns the string from the method used
        /// </summary>
        /// <param name="num">int from user</param>
        /// <param name="dec">double from user</param>
        /// <param name="letter">char from user</param>
        /// <param name="word">string from user</param>
        /// <returns>a string that is the result of the method called by CallFunc()</returns>
        public string FuncReturn(int num, double dec, char letter, string word)
        {
            return CallFunc()(num, dec, letter, word);
        }
    }
}
