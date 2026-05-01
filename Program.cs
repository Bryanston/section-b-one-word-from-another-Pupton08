// Console template
using System;
class Program
{
    static void Main()
    {
        int CountItems(List<char> curList, char letter)
        {
            int counter = 0;
            foreach(char c in curList)
            {
                if (c == letter)
                {
                    counter++;
                }
            }
            return counter;
        }
        System.Console.WriteLine("words here: ");
        List<char> firstWordList = new List<char>();
        string firstWord = Console.ReadLine();
        firstWordList = firstWord.ToList<char>();
        List<char> secondWordList = new List<char>();
        string secondWord = Console.ReadLine();
        secondWordList = secondWord.ToList<char>();
        bool canBeDone = true;
        for(int i = 0;i<firstWord.Length;i++)
        {
            if(CountItems(firstWordList,firstWordList[i]) > CountItems(secondWordList,firstWordList[i]))
            {
                canBeDone = false;
                break;
            }
        }
        if(canBeDone)
        {
            System.Console.WriteLine("possible");
        }
        else
        {
            System.Console.WriteLine("not possible");
        }
    }
}
