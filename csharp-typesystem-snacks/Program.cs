namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {         

        // Generates an array of arrLength with random values from min to max in each index
            static int[] GenRandomArray(int arrLength, int randMinValue, int randMaxValue)
            {
                Random rand = new Random();
                int[] resultArr = new int[arrLength];

                for (int i = 0; i < arrLength; i++)
                {
                    resultArr[i] = rand.Next(randMinValue, randMaxValue + 1);
                }

                return resultArr;
            }

            // BONUS

            Console.WriteLine("Hello and Welcome to Snack Bar, here are your options: \n ");
            Console.WriteLine("Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.\r\nSnack 2 : L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.\r\nSnack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.\r\nSnack 4: Calcola la somma e la media dei numeri da 2 a 10.\r\nSnack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.\r\nSnack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.\r\nSnack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.\r\nSnack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.\r\nSnack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.\r\nSnack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo \n");
            
            while (true)
            {
                Console.WriteLine("Choose one by inserting Snack and the number you're interested in (Snack 4 for example):");

                string choice = Console.ReadLine();

                switch (choice.ToLower())
                {
                    case "snack 1":
                        // SNACK 1
                        Console.WriteLine("Insert two numbers please");

                        int firstNum = int.Parse(Console.ReadLine());
                        int secondNum = int.Parse(Console.ReadLine());

                        Console.WriteLine($"the biggest number is {Math.Max(firstNum, secondNum)} \n ");
                        break;

                    case "snack 2":
                        // SNACK 2
                        Console.WriteLine("Insert two words please");

                        string firstWord = Console.ReadLine();
                        string secondWord = Console.ReadLine();

                        if (firstWord.Length > secondWord.Length)
                        {
                            Console.WriteLine($"the longest word of the two is {firstWord}");
                            Console.WriteLine($"the shortest word of the two is {secondWord} \n ");
                        }
                        else if (firstWord.Length == secondWord.Length)
                        {
                            Console.WriteLine("Both words have the same length \n ");
                        }
                        else
                        {
                            Console.WriteLine($"the longest word of the two is {secondWord}");
                            Console.WriteLine($"the shortest word of the two is {firstWord} \n ");
                        }
                        break;

                    case "snack 3":
                        // SNACK 3
                        int finalResult = 0;
                        Console.WriteLine("Insert 10 times a number of your choice please");
                        for (int i = 0; i < 10; i++)
                        {
                            int numToInsert = int.Parse(Console.ReadLine());
                            finalResult += numToInsert;
                        }
                        Console.WriteLine($"the sum of all the numbers you inserted is {finalResult} \n ");
                        break;

                    case "snack 4":
                        // SNACK 4
                        Console.WriteLine($"Sum all the numbers from 2 to 10 and print the result and their average");
                        int sum = 0;
                        for (int i = 2; i <= 10; i++)
                        {
                            sum += i;
                        }
                        int avg = sum / 9;
                        Console.WriteLine($"the sum of the numbers from 2 to 10 is {sum}");
                        Console.WriteLine($"the average of the numbers from 2 to 10 is {avg} \n ");
                        break;

                    case "snack 5":
                        // SNACK 5
                        Console.WriteLine("Insert a number please");

                        int evenUneven = int.Parse(Console.ReadLine());

                        if (evenUneven % 2 == 0)
                        {
                            Console.WriteLine($"the number inserted is even: {evenUneven} \n ");
                        }
                        else
                        {
                            Console.WriteLine($"the number inserted is uneven so here is the next: {evenUneven + 1} \n ");
                        }
                        break;

                    case "snack 6":
                        // SNACK 6
                        string[] invitedGuests = { "marco", "giulio", "roy", "bryan", "davide" };
                        Console.WriteLine("Whats 's your name");
                        string guestName = Console.ReadLine();

                        if (invitedGuests.Contains(guestName.ToLower()))
                        {
                            Console.WriteLine($"Welcome to the party {guestName} \n");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry {guestName} you 're not on the list \n ");
                        }
                        break;

                    case "snack 7":
                        // SNACK 7
                        List<int> fillInList = new List<int>();

                        Console.WriteLine("Insert 6 times a number of your choice please");

                        for (int i = 0; i < 6; i++)
                        {
                            int numToPush = int.Parse(Console.ReadLine());

                            if (numToPush % 2 != 0)
                            {
                                fillInList.Add(numToPush);
                            }
                        }

                        int[] fillInArr = fillInList.ToArray();

                        if (fillInArr.Length > 0)
                        {
                            Console.Write("the uneven numbers inserted in the array are: ");
                            foreach (var item in fillInArr)
                            {
                                Console.Write(item + ",");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Empty Array \n ");
                        }
                        break;

                    case "snack 8":
                        // SNACK 8
                        int[] intNumArr = { 2, 4, 7, 8, 9, 4, 6, 7, 8, 3, 2 };
                        int sumUnevenIndex = 0;

                        for (int i = 1; i < intNumArr.Length; i += 2)
                        {
                            sumUnevenIndex += intNumArr[i];
                        }

                        Console.WriteLine($"the sum of the numbers at uneven indexes is {sumUnevenIndex} \n ");
                        break;

                    case "snack 9":
                        // SNACK 9
                        List<int> underFifty = new List<int>();
                        int sumToFifty = 0;

                        Console.WriteLine("Enter numbers to be inserted into the array. it will stop asking when the sum of the numbers inserted is greater than or equal to 50.");

                        while (sumToFifty < 50)
                        {
                            int numToInsert = int.Parse(Console.ReadLine());
                            underFifty.Add(numToInsert);
                            sumToFifty += numToInsert;
                        }

                        if (sumToFifty >= 50)
                        {
                            Console.Write("the numbers inserted reached or are more than fifty, they are: ");
                            foreach (int key in underFifty)
                            {
                                Console.WriteLine(key + ",");
                            }
                        }
                        break;

                    case "snack 10":
                        // SNACK 10
                        Console.WriteLine("Insert a number please \n ");

                        int N = int.Parse(Console.ReadLine());

                        if (N > 0)
                        {
                            for (int i = 1; i <= N; i++)
                            {
                                int[] randomArray = GenRandomArray(10, 1, 100);

                                Console.WriteLine($"Array {i}:");

                                foreach (int key in randomArray)
                                {
                                    Console.Write(key + ",");
                                }

                                Console.WriteLine();
                            }
                        }
                        break;               

                    default:
                        Console.WriteLine("Insert your option as follows Snack 'number wanted' ");
                        break;

                }
            }
        }
    }
}
