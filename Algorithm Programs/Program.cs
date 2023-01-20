namespace Algorithm_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!");
            Console.WriteLine("1 Permutation Using Recursion\n2 Binary Search the word from wordlist");
            Console.WriteLine("Enter the option");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Enter String to find Permutation ");
                    string str = Console.ReadLine();
                    int n = str.Length;
                    Permutations.Permutate(str, 0, n - 1);
                    break;
                case 2:
                    string txtpath = File.ReadAllText(@"C:\Users\aksha\Assignments\Algorithm-Programs\Algorithm Programs\TextFile1.txt");
                    List<string> words = new List<string>(txtpath.Split());
                    words.Sort();
                    BinarySearch.BinarySearchWord(words);
                    break;

                default:
                    Console.WriteLine("Enter the valid option!");
                    break;
            }
        }            
    }
}
