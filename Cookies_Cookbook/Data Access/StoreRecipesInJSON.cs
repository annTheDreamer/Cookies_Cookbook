using System.Text.Json;

namespace Cookies_Cookbook.Data_Access
{
    public class StoreRecipesInJSON : IFileProcessor
    {
        public void Write(string filepath, List<string> selectedIngredientsIDs)
        {
            var asJson = JsonSerializer.Serialize(selectedIngredientsIDs);
            File.AppendAllText(filepath, asJson + Environment.NewLine);
        }

        public List<List<string>> Read(string filepath)
        {
            List<List<string>> recipesIDs = new List<List<string>>();
            foreach (var line in File.ReadLines(filepath))
            {
                // Deserialize each line into a list of integers
                var ids = JsonSerializer.Deserialize<List<string>>(line);

                // Add the list of numbers to the main list
                recipesIDs.Add(ids);
            }
            return recipesIDs;
        }
    }
}
