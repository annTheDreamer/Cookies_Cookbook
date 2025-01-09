using Cookies_Cookbook.Data_Access;
using Cookies_Cookbook.User_Interface;

namespace Cookies_Cookbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "recipes";
            //choose type of file recipes should be saved in
            string filePath = $"{fileName}.{FileFormat.json}";

            var PrintMessage = new UI();
            var WriteToTextFile = new StoreRecipesAsText();
            var WriteToJSON = new StoreRecipesInJSON();

            //check for previously saved recipes
            //List<List<string>> recipes = StringsTextualRepository.Read(filePath); //reading from text file
            List<List<string>> recipes = WriteToJSON.ReadFromJSON(filePath);
            PrintMessage.PrintAllExistingRecipes(recipes);

            //print messages and instructions for the user

            PrintMessage.PrintCreateNewRecipeList();
            PrintMessage.AddIngredient();
            PrintMessage.PrintAddedRecipe();
            //WriteToTextFile.WriteToFile(filePath, PrintMessage.SelectedIngredientsAsString());
            WriteToJSON.WriteToJSON(filePath, PrintMessage.SelectedIngredientsAsString());
        }
    }

    public enum FileFormat
    {
        txt,
        json,
    }
}
