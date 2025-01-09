namespace Cookies_Cookbook.Data_Access
{
    public class StoreRecipesAsText : IFileProcessor
    {
        private readonly string Separator = ",";

        public List<List<string>> Read(string filePath)
        {
            var fileContents = File.ReadAllLines(filePath);
            return fileContents
                .Select(line => line.Split(new[] { Separator }, StringSplitOptions.None).ToList())
                .ToList();
        }

        public void Write(string filePath, List<string> selectedIngredients) =>
            File.AppendAllText(
                filePath,
                string.Join(Separator, selectedIngredients) + Environment.NewLine
            );
    }
}
