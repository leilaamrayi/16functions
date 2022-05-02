/*
Author: Leila Amrayi
Date: April 2022
*/


using System;	
public class Leila
{
	public static void Main()
	{

            Console.WriteLine("1 - skriva ut Hello World i konsolen");
            Console.WriteLine("2 - ta in input från användaren (Förnamn, Efternamn, Ålder) och sedan skriver ut dessa i konsolen");
            Console.WriteLine("3 - ändra färgen på texten i konsolen (och ändrar tillbaka om man använder funktionen igen");
            Console.WriteLine("4 - skriva ut dagens datum");
            Console.WriteLine("5 - ta två input värden, sedan skriver ut vilket av dem som är störst");
            Console.WriteLine("6 - generera att slumpmässigt tal mellan 1 och 100");
            Console.WriteLine("7 - skriva in en textrad, som sedan sparas i en fil på hårddisken");
            Console.WriteLine("8 - läsa in en fil från hårddisken");
            Console.WriteLine("9 - skicka in ett decimaltal och får tillbakaroten ur, upphöjt till 2 och upphöjt till 10");
            Console.WriteLine("10 - skriva ut en multiplikationstabell från 1 till 10");
            Console.WriteLine("11 - skapa två arrayer. Den första fylls med slumpmässiga tal.");
            Console.WriteLine("12 - ta en input och kontrollera ifall det är en palindrom.");
            Console.WriteLine("13 - ta två input och skriva sedan ut alla siffror som är mellan de två inputsen. ");
            Console.WriteLine("14 - skicka in ett antal värden (komma-separerade siffror) som sedan sorteras och skrivs ut.");
            Console.WriteLine("15 - skriva in ett antal värden(komma-separerade siffor) som sedan adderas och skrivs ut. ");
            Console.WriteLine("16 - skicka in ett antal värden (komma-separerade siffror) som användaren ska ange namnet på sin karaktär och namnet på en motståndare ");
            Console.WriteLine("0 -  EXIT");

        string option;

        do
        {

            Console.Write("\nPlease select an option (1 to 16) from menu, or 0 to exit:");

            option = Console.ReadLine();
            
            switch (option) {
                
                case "1":
                    Console.WriteLine("Hello World");
                    break;

                case "2":
                    option2();
                    break;
                    
                case "3":
                    option3();
                    break;

                case "4":
                    option4();
                    break;

                case "5":
                    option5();
                    break;   

                case "6":
                    option6();
                    break;

                case "7":
                    option7();
                    break;

                case "8":
                    option8();
                    break;

                case "9":
                    option9();
                    break;

                case "10":
                    option10();
                    break;

                case "11":
                    option11();
                    break;

                case "12":
                    option12();
                    break;

                 case "13":
                    option13();
                    break;

                case "14":
                    option14();
                    break;

                case "15":
                    option15();
                    break;

                case "16":
                    option16();
                    break;

                case "0":
                    Console.WriteLine("You chose EXIT!");
                    break;
                default:
                    Console.WriteLine("Invalid option! Try again.");
                    break;
            }

        } while (option != "0");
        

    }

    
    private static void option2()
    {

        String firstname, lastname, age;

		Console.WriteLine("What is your firstname?");
		firstname = Console.ReadLine();
		
		Console.WriteLine("What is your lastname?");
        lastname= Console.ReadLine();
        
		Console.WriteLine("How old are you?");
		age= Console.ReadLine();
        
		Console.WriteLine( firstname+ " "+ lastname + "!" + " you are: " + age + " years old");

    }

    private static void option3()
    {

        if (Console.ForegroundColor != ConsoleColor.Green)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Changed to green");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Changed to white");
        }

        
    }

    private static void option4()
    {
        Console.WriteLine("Date is: "+ DateTime.Now);
    }

    private static void option5()
    {
        int num1, num2;
		Console.Write("Input the 1st number :");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Input the  2nd number :");
		num2 = Convert.ToInt32(Console.ReadLine());

	    if (num1 > num2)
		{   
		     Console.Write("The 1st Number is the greatest among two");
		}

	    else if (num2 > num1)
		{
		     Console.Write("The 2nd Number is the greatest among two");
        }

    }

    private static void option6()
    {
        int numberoftries=1;
		while (true)
		{
		    Console.WriteLine ("Guess a number between 1 and 100");
			int num = new Random().Next(1, 100);
			int guess =  Convert.ToInt32(Console.ReadLine());

			if (guess == num)
			{
				Console.WriteLine("Congrats!Your guess was correct! it took you " + numberoftries+ " tries");
				break;
			}
			if (guess > num)
			{
				Console.WriteLine("Your guess was too high");
			}
			if (guess < num)
			{
				Console.WriteLine("Your guess was too low");
			}
			
      	    numberoftries++;
        }	
    }

    private static void option7()
    {
        Console.Write("Enter a line of text:");
        string text = Console.ReadLine();
        
        string fileName = "info.txt";
        File.WriteAllText(fileName,text);
        Console.WriteLine("Information saved.");

    }

    private static void option8()
    {
        string fileName = "info.txt";
        string text = File.ReadAllText(fileName);
        Console.WriteLine("File content is: \n"+text);
    }

    private static void option9()
    {
        Double num;
		Console.Write("Input a decimal number :");
		num = Convert.ToDouble(Console.ReadLine());
        Double root = Math.Sqrt(num);
        Console.WriteLine("Square root is: "+root);
        Console.WriteLine("Square root ^  2 is: "+Math.Pow(root,2));
        Console.WriteLine("Square root ^ 10 is: "+Math.Pow(root,10));
    }

    private static void option10()
    {
        Console.WriteLine("Multiplication Table");

        for (int i = 1; i <= 10; i++)
        {
            for (int j =1; j <= 10; j++)
            {
                Console.WriteLine("{0}*{1} =\t{2}", i, j, i*j);
            }
        }

    }

    private static void option11()
    {
        Random random = new Random();
        int [] numbers = new int[10];
        int [] numbers2 = new int[10];

        for (int i = 0; i < 10; i++)
        { 
            numbers[i] = random.Next(1, 100);
        }

        Console.WriteLine("numbers before sort : {0}", String.Join(",", numbers));

        int temp = 0;

        for (int i = 0; i < numbers.Length; i++) 
        {
            for (int j = 0; j < numbers.Length -1 ; j++) 
            {
                if (numbers[j] > numbers[j + 1]) 
                {
                    temp = numbers[j + 1];

                    numbers[j + 1] = numbers[j];
                    numbers[j] = temp;

                    // copy to second array
                    numbers2[j + 1] = numbers[j + 1];
                    numbers2[j] = numbers[j];
                }
            }
        }

        Console.WriteLine("second numbers array after sort : {0}", String.Join(",", numbers2));
    }

    private static void option12()
    {
        string str, rev;
        rev = "";

        Console.Write("Enter a word:");
        str = Console.ReadLine();
        
        // reverse str into the rev variable 
        foreach (char c in str.ToCharArray())
        {
            rev = c + rev;
        } 

        if (str == rev) 
        {
            Console.WriteLine(str + " is a Palindrome!");
        }
		else
		{
            Console.WriteLine(str + " is not a Palindrome!");
        }

    }

    private static void option13()
    {
        int startingNumber, endingNumbeer;  
          
        Console.Write("Enter Starting Number : ");  
        startingNumber = int.Parse(Console.ReadLine());  
        Console.Write("Enter Ending Number : ");  
        endingNumbeer = int.Parse(Console.ReadLine());  

        Console.WriteLine("Below are the all number between " + startingNumber + " and " + endingNumbeer);  
            
        for (int i = startingNumber +1; i < endingNumbeer;)  
        {  
            Console.Write(" "+i++);
        }  

    }

    private static void option14()
    {
        Console.Write("Enter some numbers, separated by comma: ");  
        string input = Console.ReadLine();
        string[] separatedInputs = input.Split(",");
        int[] numbers = new int[separatedInputs.Length];

        for (int i = 0; i < separatedInputs.Length; i++)  
        {  
            numbers[i] = int.Parse(separatedInputs[i]);
        }

        int temp = 0;
        for (int i = 0; i < numbers.Length; i++) 
        {
            for (int j = 0; j < numbers.Length -1 ; j++) 
            {
                if (numbers[j] > numbers[j + 1]) 
                {
                    temp = numbers[j + 1];
                    numbers[j + 1] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }

        Console.WriteLine("Even numbers: ");

        foreach (int i in numbers)
        {
            if (i % 2 == 0){
                Console.Write(" \t"+i);
            }
        }

        Console.WriteLine("\nOdd numbers: ");

        foreach (int i in numbers)
        {
            if (i % 2 != 0){
                Console.Write(" \t"+i);
            }
        }

    }

    private static void option15()
    {
        Console.Write("Enter five numbers which are separated by comma:");
        string input = Console.ReadLine();	
        string[] split = input.Split(',');
        
        int sum = 0;
        
        foreach (string item in split)
        {
            int num = int.Parse(item);
            sum = sum + num;
        }

        Console.WriteLine("Sum is : "+sum);

    }

    private static void option16()
    {
        Console.Write("Enter your character's name:");
        string characterName = Console.ReadLine();
        Console.Write("Enter the opponent's name:");
        string opponentName = Console.ReadLine();

        Random random = new Random();

        Character character = new Character 
        {
            name = characterName,
            health = random.Next(1,10),
            strength = random.Next(1,10),
            luck = random.Next(1,10)
        };

        Character opponent = new Character 
        {
            name = opponentName,
            health = random.Next(1,10),
            strength = random.Next(1,10),
            luck = random.Next(1,10)
        };

        Console.WriteLine("{0} ==> Health: {1} , Strength: {2} , Luck: {3}", 
            character.name , character.health , character.strength , character.luck);

        Console.WriteLine("{0} ==> Health: {1} , Strength: {2} , Luck: {3}", 
            opponent.name , opponent.health , opponent.strength , opponent.luck);
        
    }

    class Character 
    {
        public string name {get; set;}
        public int health {get; set;}
        public int strength {get; set;}
        public int luck {get; set;}
    }


}