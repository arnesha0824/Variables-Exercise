namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string catName = "Cali";
            int age = 10;
            char iniital = 'B';
            bool married = true;
            double houses = 40.00;
            decimal islands = 10.3m;

            Console.WriteLine($"My cat's name is {catName}, She is {age} years old");
            Console.WriteLine($"Married: {married} and has {houses} houses. On {islands} islands");
        }
    }
}
