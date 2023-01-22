namespace Algorithm_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!");
            Console.WriteLine("1 Permutation Using Recursion\n2 Binary Search the word from wordlist" +
                "\n3 Insertion Sort\n4 Bubble Sort\n5 Merge Sort\n6 Anagram\n7 Prime Number in range " +
                "\n8 Prime numbers with anagrams and palindrome");
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
                case 3:
                    InsertionSort insertionSort = new InsertionSort();
                    int[] arr = { 10, 2, 14, 3, 1, 5, 9 };
                    insertionSort.Sort(arr);
                    insertionSort.PrintArray(arr);
                    break;
                case 4:
                    int[] arr1 = { 10, 2, 14, 3, 1, 5, 9 };
                    BubbleSort.BubbleSortInArray(arr1);
                    BubbleSort.PrintArray(arr1);
                    break;
                case 5:
                    int[] arr2 = { 32, 12, 9, 65, 24, 5 };
                    MergeSort.Sort(arr2, 0, arr2.Length - 1);
                    MergeSort.PrintArray(arr2);
                    break;
                case 6:
                    Anagram.FindAnagram();
                    break;
                case 7:
                    Console.WriteLine("The prime numbers are : ");
                    PrimeNumInRange primeNum = new PrimeNumInRange();
                    primeNum.FindPrime();
                    break;
                case 8:
                    PrimePalindrome primePalindrome = new PrimePalindrome();
                    Console.Write("\nPrime Palindromes Between Range 1 to 1000 Are: ");
                    primePalindrome.Primepalindrome();
                    break;

                default:
                    Console.WriteLine("Enter the valid option!");
                    break;
            }
        }            
    }
}
