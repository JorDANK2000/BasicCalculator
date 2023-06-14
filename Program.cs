//Basic Calculator program created to further practice with numbers and math operations in C#
//Created by Jordan King on 06-05-2023
int userOption = 0;
Console.WriteLine("Welcome to my basic caluclator program");
do{
    double numOne = 0;
    double numTwo = 0;
    int chosenOperation = 0;
    double result;
    Console.WriteLine("Enter first operand: ");
    Double.TryParse(Console.ReadLine(), out numOne);
    Console.WriteLine("Enter second operand");
    Double.TryParse(Console.ReadLine(), out numTwo);
    Console.WriteLine("Select operation to be performed: \n1: Addition\n2: Subtraction\n3: Multiplication\n4: Division");
    
    Int32.TryParse(Console.ReadLine(), out chosenOperation);
    switch (chosenOperation)
    {
        case 1 :
            result = numOne + numTwo;
            Console.WriteLine($"The result of your addition operation is : {result}");
            break;
        case 2 :
            result = numOne - numTwo;
            Console.WriteLine($"The result of your subtraction operation is : {result}");
            break;
        case 3 :
            result = numOne * numTwo;
            Console.WriteLine($"The result of your multiplication operation is : {result}");
            break;
        case 4 :
            result = numOne / numTwo;
            Console.WriteLine($"The result of your division operation is : {result}");
            break;
        default:
            Console.WriteLine("That was not a vaild input to select operation");
            break;
    }
    Console.WriteLine("Select an option from the list below:");
    Console.WriteLine("1: Continue to use calculator");
    Console.WriteLine("2: Exit Program");
    Int32.TryParse(Console.ReadLine(), out userOption);
} while(userOption != 2);