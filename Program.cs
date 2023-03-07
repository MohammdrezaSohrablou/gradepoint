
//  Mohammadreza Sohrablou ----------- محمدرضا سهراب لو //

using System.Diagnostics;
using System.Numerics;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

double score;
bool a;
string input;
do
{
    
    num0to20();
    
    AskToContinue();

} while (input.ToLower() == "y");
Console.WriteLine("Good Luck !");


//-------------------- Methods --------------------// 


// This method only accepts numbers from 0 to 20
void num0to20()
{
    do
    {
        Console.WriteLine("Enter your grade: ");
        score = double.Parse(Console.ReadLine());
        if (score < 0 || score > 20)
        {
            a = true;
            Console.WriteLine("invalid number! enter a number between 0 and 20");
        }
        else
        {
            a = false;
            rankofgrade();
            percentage();
            //percentageANDrank();  we can use this method instead of 'rankofgrade();'  and  'percentage();'
        }
    } while (a);
}

// This method calculates the rank of your score
void rankofgrade()
{
     if (score >= 17)
    {
        Console.WriteLine("Excellent, Your grade is A");
    }
    else if (score >= 15)
    {
        Console.WriteLine("Good Job, Your grade is B");
    }
    else if (score >= 10)
    {
        Console.WriteLine("Not Bad, Your grade is C");
    }
    else
    {
        Console.WriteLine("Failed");
    }
    
}

// This method calculates the percentage of your score
void percentage()
{
    double percentage = (score / 20) * 100;
    Console.WriteLine("Percentage: " + percentage + "%");
}

//This method locks the keyboard and only accepts letters 'Y' and 'N'
void AskToContinue()
{
    Console.WriteLine("Do you want to continue? y,n:");
    do
    {
        input = Console.ReadKey(true).KeyChar.ToString();
    } while (input.ToLower() != "y" && input.ToLower() != "n");
}


//void percentageANDrank()
//{
//    double percentage = (score / 20) * 100;
//    if (percentage >= 85)
//    {
//        Console.WriteLine("Excellent, Your grade is A");
//    }
//    else if (percentage >= 75)
//    {
//        Console.WriteLine("Good Job, Your grade is B");
//    }
//    else if (percentage >= 50)
//    {
//        Console.WriteLine("Not Bad, Your grade is C");
//    }
//    else
//    {
//        Console.WriteLine("Failed");
//    }
//    Console.WriteLine("your percent age is " + percentage + "%");
//}