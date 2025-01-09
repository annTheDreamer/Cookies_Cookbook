namespace Cookies_Cookbook.Data_Access
{
    internal static class StringsTextualRepository //reads and writes from text files
    {
        private static readonly string Separator = ",";

        public static List<List<string>> Read(string filePath)
        {
            var fileContents = File.ReadAllLines(filePath);
            return fileContents
                .Select(line => line.Split(new[] { Separator }, StringSplitOptions.None).ToList())
                .ToList();
        }

        public static void Write(string filePath, List<string> strings) =>
            File.AppendAllText(filePath, string.Join(Separator, strings) + Environment.NewLine);
    }
}
