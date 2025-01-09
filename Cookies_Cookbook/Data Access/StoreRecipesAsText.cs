namespace Cookies_Cookbook.Data_Access
{
    public class StoreRecipesAsText
    {
        public void WriteToFile(string filePath, List<string> selectedIngredients)
        {
            StringsTextualRepository.Write(filePath, selectedIngredients);
        }
    }
}
