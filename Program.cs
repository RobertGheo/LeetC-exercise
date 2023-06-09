// See https://aka.ms/new-console-template for more information
using LeetC_exercise.DifficultyEasy;

Console.WriteLine("Hello there \n");
Console.WriteLine("This is a console app with the Leet Code exercise \nPracticing them and implementing in a program\n");

bool quitVar = false;
while (quitVar == false)
{
    Console.Write("\nSelect a menu option: ");
    string inputMenu = Console.ReadLine().Trim().ToLower();

    switch (inputMenu)
    {
        case "a1":
            A1_TwoSum.mMain();
            break;
        case "a2":
            A2_PalindromeNumber.mMain(); 
            break;


        case "q":
            quitVar = true;
            break;
        default:
            Console.WriteLine("\tWrong input, please insert a menu option");
            break;
    }
}
 


