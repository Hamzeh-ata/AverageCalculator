public class AverageCalculator
{
    public static void Main(string[] args)
    {
        List<int> addedNumbers = new();
        string existInput = "-1";

        Console.WriteLine("Please enter an integer numbers. Enter -1 to exit.");

        while (true)
        {
            string input = Console.ReadLine();

            if (input == existInput)
            {
                break;
            }

            if (int.TryParse(input, out int number))
            {
                addedNumbers.Add(number);
            }

            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        if (addedNumbers.Count > 0)
        {
            var average = CalculateAverage(addedNumbers);
            Console.WriteLine($"The average of the entered numbers is: {average}");
        }

        else
        {
            Console.WriteLine("No entered numbers were found");
        }

    }
    private static double CalculateAverage(List<int> numbers)
    {
        int sum = numbers.Sum();
        return Math.Round(sum / (double)numbers.Count, 2);
    }
}