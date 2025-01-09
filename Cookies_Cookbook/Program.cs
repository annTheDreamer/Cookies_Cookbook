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
            string filePath = $"{fileName}.{FileFormat.txt}";

            // Extract the file extension
            string fileExtension = Path.GetExtension(filePath).ToLower();

            var PrintMessage = new UI();

            //variable for saving all existing recipes
            List<List<string>> recipes = new List<List<string>>();

            switch (fileExtension)
            {
                case ".txt":
                    var TextFile = new StoreRecipesAsText();

                    //check for previously saved recipes
                    recipes = TextFile.Read(filePath);
                    PrintMessage.PrintAllExistingRecipes(recipes);

                    //print messages and instructions for the user
                    PrintMessage.AddRecipe();

                    //write new recipe to file
                    TextFile.Write(filePath, PrintMessage.SelectedIngredientsAsString());
                    break;
                case ".json":
                    var JSON = new StoreRecipesInJSON();

                    //check for previously saved recipes
                    recipes = JSON.Read(filePath);
                    PrintMessage.PrintAllExistingRecipes(recipes);

                    //print messages and instructions for the user
                    PrintMessage.AddRecipe();

                    //write new recipe to file
                    JSON.Write(filePath, PrintMessage.SelectedIngredientsAsString());
                    break;
                default:
                    break;
            }
        }
    }

    public enum FileFormat
    {
        txt,
        json,
    }
}
