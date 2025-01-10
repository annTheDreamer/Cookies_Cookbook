using Cookies_Cookbook.Data_Access;
using Cookies_Cookbook.Ingredients;

namespace Cookies_Cookbook.User_Interface
{
    public class UI
    {
        public void AddRecipe()
        {
            PrintCreateNewRecipeList();
            IngredientManagement.AddIngredient();
            PrintAddedRecipe();
        }

        public void PrintCreateNewRecipeList()
        {
            Console.WriteLine();
            Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
            Console.WriteLine();
            foreach (Ingredient ingredient in IngredientManagement.GetIngredients())
            {
                Console.WriteLine($"{ingredient.Id}. {ingredient.Name}");
            }
        }

        public void PrintAddedRecipe()
        {
            if (IngredientManagement.GetSelectedIngredients().Count() > 0)
            {
                Console.WriteLine("Recipe added:");
                foreach (int selectedIngredient in IngredientManagement.GetSelectedIngredients())
                {
                    foreach (Ingredient ingredient in IngredientManagement.GetIngredients())
                    {
                        if (selectedIngredient == ingredient.Id)
                            Console.WriteLine($"{ingredient.Name}. {ingredient.Prepare()}");
                    }
                }
            }
        }

        public void PrintExistingRecipe(List<string> recipe)
        {
            foreach (string ingredientID in recipe)
            {
                foreach (Ingredient ingredient in IngredientManagement.GetIngredients())
                {
                    if (ingredientID == ingredient.Id.ToString())
                        Console.WriteLine($"{ingredient.Name}. {ingredient.Prepare()}");
                }
            }
        }

        public void PrintAllExistingRecipes(List<List<string>> recipes)
        {
            bool hasValidRecipes = recipes.Any(recipe =>
                recipe != null && recipe.Count > 0 && !recipe.All(string.IsNullOrWhiteSpace)
            );
            if (hasValidRecipes)
            {
                int recipeNumber = 1;
                Console.WriteLine("Existing recipes are:");

                for (int i = 0; i < recipes.Count; i++)
                {
                    if (
                        recipes[i] == null
                        || recipes[i].Count == 0
                        || recipes[i].All(string.IsNullOrWhiteSpace)
                    )
                        continue;
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"***** {recipeNumber} *****");
                        PrintExistingRecipe(recipes[i]);
                        recipeNumber++;
                    }
                }
            }
        }
    }
}
