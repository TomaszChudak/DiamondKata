namespace DiamondKata
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!InputArgumentChecker.CheckIfSingleLetter(args))
            {
                Console.WriteLine("Please enter only one letter as input argument.");
                return;
            }

            var result = DiamondStringCreator.Create(args[0][0]);

            Console.WriteLine(result);
        }
    }
}