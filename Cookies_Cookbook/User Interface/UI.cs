using Cookies_Cookbook.Ingredients;

namespace Cookies_Cookbook.User_Interface
{
    public class UI
    {
        List<Ingredient> listOfIngredients = new List<Ingredient>
        {
            new WheatFlour(),
            new CoconutFlour(),
            new Butter(),
            new Chocolate(),
            new Sugar(),
            new Cardamom(),
            new Cinnamon(),
            new CocoaPowder(),
        };

        public List<int> selectedIngredients = new List<int>();

        public void AddRecipe()
        {
            PrintCreateNewRecipeList();
            AddIngredient();
            PrintAddedRecipe();
        }

        public void PrintCreateNewRecipeList()
        {
            Console.WriteLine();
            Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
            Console.WriteLine();
            foreach (Ingredient ingredient in listOfIngredients)
            {
                Console.WriteLine($"{ingredient.Id}. {ingredient.Name}");
            }
        }

        public void AddIngredient()
        {
            bool inputIsNumber = true;
            while (inputIsNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
                string userInput = Console.ReadLine();
                inputIsNumber = int.TryParse(userInput, out int ingredientID);
                foreach (Ingredient ingredient in listOfIngredients)
                {
                    if (ingredient.Id == ingredientID)
                        selectedIngredients.Add(ingredientID);
                }
            }
        }

        public List<string> SelectedIngredientsAsString()
        {
            List<string> selectedIngredientsAsString = new List<string>();
            foreach (int ingredient in selectedIngredients)
            {
                selectedIngredientsAsString.Add(ingredient.ToString());
            }
            return selectedIngredientsAsString;
        }

        public void PrintAddedRecipe()
        {
            Console.WriteLine("Recipe added:");
            foreach (int selectedIngredient in selectedIngredients)
            {
                foreach (Ingredient ingredient in listOfIngredients)
                {
                    if (selectedIngredient == ingredient.Id)
                        Console.WriteLine($"{ingredient.Name}. {ingredient.Prepare()}");
                }
            }
        }

        public void PrintExistingRecipe(List<string> recipe)
        {
            foreach (string ingredientID in recipe)
            {
                foreach (Ingredient ingredient in listOfIngredients)
                {
                    if (ingredientID == ingredient.Id.ToString())
                        Console.WriteLine($"{ingredient.Name}. {ingredient.Prepare()}");
                }
            }
        }

        public void PrintAllExistingRecipes(List<List<string>> recipes)
        {
            Console.WriteLine("Existing recipes are:");
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"***** {i + 1} *****");
                PrintExistingRecipe(recipes[i]);
            }
        }
    }
}
