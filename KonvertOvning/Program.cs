using System.Runtime.ConstrainedExecution;

namespace KonvertOvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //**Ö1. Temperaturomvandlare**
            //Skriv ett program som ber användaren mata in en temperatur i Celsius.
            //Konvertera texten till ett decimaltal och räkna om till Fahrenheit med formeln F = C × 9 / 5 + 32.
            //Skriv ut resultatet.


            //Console.WriteLine("Skriv in temperatur i Celsius: ");
            //int C = int.Parse(Console.ReadLine());
            //double F = ((double)C * 9 / 5) + 32;

            //Console.WriteLine(F);

            ////Ö2. Säker inmatning
            ////Be användaren mata in ett heltal.
            ////Använd TryParse för att kontrollera inmatningen.
            ////Om användaren skriver något som inte är ett tal ska programmet skriva "Fel inmatning" istället för att krascha.

            //Console.WriteLine("Mata in ett heltal: ");
            //string number = Console.ReadLine();
            //int result = 0;
            //bool IsConverted = int.TryParse(number, out result); 

            //if (IsConverted)
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Fel inmatning");
            //}

            //Ö3.Tärningskastare
            //Skapa ett program som slumpar fram ett tärningsslag mellan 1-6 och skriver ut resultatet.
            //Låt användaren trycka enter för att slå igen.

            //Random slump = new Random();
            //string answer;
            //do
            //{
            //    int dice = slump.Next(1, 7);
            //    Console.WriteLine($"Du slog: {dice}");
            //    Console.WriteLine("Tryck ENTER för att slå igen, valfri annan tangent och ENTER för att avsluta");
            //    answer = Console.ReadLine();
            //} while (answer == "");

            //Ö 5 Säker inmatning
            //Bygg en miniräknare som frågar efter två tal och räknesätt +-*/.
            //Använd try-catch för att hantera felaktig inmatning och division med noll.

            //Console.WriteLine("Välkommen till miniräknaren");
            //try
            //{
            //    Console.WriteLine("Skriv in första talet: ");
            //    double num1 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Skriv in andra talet: ");
            //    double num2 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Välj räknesätt (+, -, *, /): ");
            //    string count = Console.ReadLine();

            //    double result = 0;
            //    bool correctCount = true;

            //    switch (count)
            //    {
            //        case "+":
            //            result = num1 + num2;
            //            break;
            //        case "-":
            //            result = num1 - num2;
            //            break;
            //        case "*":
            //            result = num1 * num2;
            //            break;
            //        case "/":
            //            if (num2 == 0)
            //            {
            //                throw new DivideByZeroException("Det går inte att dela med noll.");
            //            }
            //            result = num1 / num2;
            //            break;
            //        default:
            //            Console.WriteLine("Fel ogiltigt räknesätt använd +, -, *, /.");
            //            correctCount = false;
            //            break;
            //    }
            //    if (correctCount)
            //    {
            //        Console.WriteLine($"Resultat: {num1} {count} {num2} = {result}");
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Fel: du måste använda siffror.");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Fel: Du kan inte dela med noll.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Ett oväntat fel uppstod, försök igen.");
            //}
            //Console.WriteLine("Tryck valfri tangent för att avsluta");
            //Console.ReadKey();

            //Ö6 Gissa talet
            //Slumpa fram ett tal mellan 1-100. Användaren gissar tills rätt tal hittas.
            //Efter varje gissning ges ledtråd "högre" eller "lägre".
            //När gissat rätt visa antal gissningar

            //Random ran = new Random();
            //int SecretNumber = ran.Next(1, 101);
            //int guess = 0;
            //int guesses = 0;
            //Console.WriteLine("Gissa rätt nummer mellan 1-100");
            ////if för att ge högre lägre
            //// do while loop
            //while (guess != SecretNumber)
            //{
            //    Console.WriteLine("Skriv din gissning mellan 1-100");

            //    if (int.TryParse(Console.ReadLine(), out guess))
            //    {
            //        guesses++;
            //        if (guess < SecretNumber)
            //        {
            //            Console.WriteLine("Gissa högre");
            //        }
            //        else if (guess > SecretNumber)
            //        {
            //            Console.WriteLine("Gissa lägre");
            //        }
            //        else if (guess == SecretNumber)
            //        {
            //            Console.WriteLine($"\nRätt! Du klarade det på {guesses} försök");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Vänligen mata in ett giltigt nummer.");
            //    }

            //}

            //Ö7 var vs dynamic
            //Skapa ett program där du deklarerar tre variabler med var och tre med dynamic.
            //Testa att ändra typen på dynamic-variabeln under körning och skriv en kommentar om vad som händer.
            //Provocera fram ett körningsfel med dynamic och åtgärda det.
            //Förklara skillnaden mellan var och dynamic.

            //var name1 = "Kristin"; //deklarerar string
            //var age1 = 5; //deklarerar int
            //var price1 = 10.90; //deklarerar double

            //dynamic name2 = "Henrik"; //Deklarerar string
            //dynamic age2 = 7; //deklarerar int
            //dynamic price2 = 11.90; //deklarerar double
            //Console.WriteLine(age2.GetType()); //Skriver ut System.Int32 
            //age2 = "Lucas";
            //Console.WriteLine(age2.GetType()); //Skriver ut System.String, har ändrat från int till string

            //Console.WriteLine(name2.Length); // 6 - funkar innan ändring till int
            //name2 = 3; //nu har jag gjort om den till int
            //Console.WriteLine(name2.Length); //Krasch som runtime. För att åtgärda måste jag återgå till string och istället använda age2 för min int variabel.
            ////var låter kompilatorn gissa typen direkt vid kompilering (kodning). väljer man inte en typ får man ett fel direkt i koden.
            ////dynamic har ingen riktig koll på vad den är innan koden körs och då antingen fungerar det eller kraschar.

            //Ö9 Robust registreringssystem
            //Bygg ett program som samlar in namn, ålder och lön från användaren.
            //All numerisk inmatning ska valideras med Try.Parse
            //Kasta ett eget fel om åldern är under 0 eller över 120.
            //Fånga och hantera alla fel snyggt så programmet aldrig kraschar.
            //try
            //{
            //    Console.WriteLine("Ange namn: ");
            //    string name = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(name))
            //    {
            //        throw new FormatException("Namnet får inte vara tomt.");
            //    }
            //    Console.WriteLine("Ange ålder: ");
            //    if (!int.TryParse(Console.ReadLine(), out int age))
            //    {
            //        throw new FormatException("\nÅldern måste vara ett heltal");
            //    }
            //    if (age < 0 || age > 120)
            //    {
            //        throw new IndexOutOfRangeException($"\nFel: Åldern {age} måste vara mellan 0-120 år");
            //    }
            //    Console.WriteLine("Ange lön: ");
            //    if (!int.TryParse(Console.ReadLine(), out int salary))
            //    {
            //        throw new FormatException("\nLönen måste vara ett heltal.");
            //    }
            //    Console.WriteLine($"Namn: {name}");
            //    Console.WriteLine($"Ålder: {age} år");
            //    Console.WriteLine($"Lön: {salary}");
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Inmatningsfel: {ex.Message}");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Inmatningsfel: {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Ett oväntat fel uppstod: {ex.Message}");
            //}
            //Console.WriteLine("Tryck in valfri tangent för att avsluta!");
            //Console.ReadKey();

            //Ö 10 Slumpgenererat quiz
            //Skapa ett quiz som slumpar fram fem matteuppgifter (t.ex multiplikation).
            //Samla in svaren, hantera felaktig inmatning och visa antal rätt på slutet.
            //Använd brytpunkter för att felsöka poängräkningen.

            //Random random = new Random();
            //int totalQuestions = 5;
            //int score = 0;

            //Console.WriteLine("Välkommen till mattesquizet!");
            //Console.WriteLine($"Du kommer att få {totalQuestions} multiplikationsuppgifter.\n");

            //for (int i = 1; i <= totalQuestions; i++)
            //{
            //    int number1 = random.Next(2, 11);
            //    int number2 = random.Next(2, 11);
            //    int correctAnswer = number1 + number2;

            //    Console.Write($"Fråga {i}: Vad är {number1} + {number2}? ");

            //    int userAnswer = 0;
            //    bool isValidInput = false;

            //    while (!isValidInput)
            //    {
            //        Console.WriteLine();
            //        string input = Console.ReadLine();
            //        isValidInput = int.TryParse(input, out userAnswer);

            //        if (!isValidInput)
            //        {
            //            Console.Write("Felaktig inmatning. Ange ett heltal med siffror: ");
            //        }
            //    }

            //    if (userAnswer == correctAnswer)
            //    {
            //        Console.WriteLine("Rätt svar!\n");
            //        //Brytpunkt för att kontrollera att poängen ökar vid rätt svar              

            //        score++; 
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Fel. Rätt svar var {correctAnswer}.\n");
            //       //brytpunkt för att kontrollera att poängen inte ökar vid fel svar
            //    }
            //} //brytpunkt för att kontrollera slutliga poängen före utskrift

            //Console.WriteLine($"Quizet är klart! Du fick {score} av {totalQuestions} rätt.");
            //Console.ReadLine();

            //Ö12 Felsökningsutmaning
            //Du får en kodfil som innehåller tre buggar.
            //Använd VisualStudios felsökare-brytpunkter och watch fönstret-för att hitta och rätta felen.
            //Beskriv varje bugg och hur du löste den

            int[] tal = { 5, 10, 15, 20 };
            int summa = 0;
            for (int i = 0; i < tal.Length; i++)
                summa += tal[i];
            double medel = (double)summa / tal.Length;
            Console.WriteLine($"Medel: {medel}");
            //Finns inga fel i denna kod. Den fungerar som tänkt, man får ut ett medelvärde av Arrayn i int.

        }
    }
}
