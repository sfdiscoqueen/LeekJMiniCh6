// Jasmine Leek
// 20oct2022
// Mini Challenge #6 "Odd or Even"
// This is a program that takes in a user's input, determines if the input is a valid number,
// then prints out if the number entered is odd or even before asking the user if they want to play again


Console.Clear();

bool playAgain = true;

while (playAgain)
{
    bool isNum;
    int validNum = 0;


    Console.Write("Let's determine if a number is odd or even.\n \nPlease enter a number: ");
    string userNum = Console.ReadLine();

    isNum = Int32.TryParse(userNum, out validNum);

    Console.WriteLine("");

    if (isNum == true)
    {
        int i = (validNum % 2);

        if (i == 0)
        {
            Console.WriteLine($"{userNum} is an even number.");
        }
        else if (i == 1)
        {
            Console.WriteLine($"{userNum} is an odd number.");
        }
    }
    else
    {
        Console.WriteLine("Invalid entry. Please enter a number next time!");
    }

    Console.WriteLine("\nWant to play again? Enter any key to restart or type 'end' to quit\n");
    string ready = Console.ReadLine();

    if (ready == "end")
    {
        playAgain = false;
    }
}