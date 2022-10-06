//This is asking the user for an input for the first module, then the second line is accepting the input and making sure the console knows its an INt
Console.WriteLine("What is your result for the first module? ");
int moduleOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your result for the second module? ");
int moduleTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your result for the third module? ");
int moduleThree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your result for the fourth module? ");
int moduleFour = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your result for the fifth module? ");
int moduleFive = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your result for the sixth module? ");
int moduleSix = Convert.ToInt32(Console.ReadLine());

//This line of code adds up all of the previous inputs from the user and makes it 1 variable
int totalGrade = (moduleOne + moduleTwo + moduleThree + moduleFour + moduleFive + moduleSix) / 6;
//This print statement tells the user the sum of all of the previous inputs before deciding what grade they got.
Console.WriteLine("Your overall grade is " + totalGrade);


//This if statement is asking itself if the user's totalGrade variable is one of the following, greater than 69, greater than 59, greater than 49, greater than 40 or equal to 40.
//Depending on the result, the console will print a response listed from below, corresponding to the previous sum of the inputs.
switch (totalGrade)
{
    case > 69:
        Console.WriteLine("You have achieved a 1st");
        break;

    case > 59:
        Console.WriteLine("You have achieved a 2:1");
        break;

    case > 49:
        Console.WriteLine("You have achieved a 2:2");
        break;

    case > 40:
        Console.WriteLine("You have achieved a 3rd");
        break;

    case 40:
        Console.WriteLine("You have achieved a Pass");
        break;

    default:
        Console.WriteLine("You have Failed :(");
        break;
}

Console.ReadLine();
