namespace DiamondKata
{
    public static class InputArgumentChecker
    {
        public static bool CheckIfSingleLetter(string[] args)
        {
            return args.Length == 1
                && args[0]?.Length == 1
                && char.IsLetter(args[0][0]);
        }
    }
}