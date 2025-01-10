using Cookies_Cookbook.Ingredients;

namespace Cookies_Cookbook.Data_Access
{
    public static class IngredientManagement
    {
        private static List<Ingredient> listOfIngredients = new List<Ingredient>
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

        private static List<int> selectedIngredients = new List<int>();

        public static void AddIngredient()
        {
            bool inputIsNumber = true;
            while (inputIsNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
                string userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                    break;
                inputIsNumber = int.TryParse(userInput, out int ingredientID);
                foreach (Ingredient ingredient in listOfIngredients)
                {
                    if (ingredient.Id == ingredientID)
                        selectedIngredients.Add(ingredientID);
                }
            }
        }

        public static List<Ingredient> GetIngredients() => listOfIngredients;

        public static List<int> GetSelectedIngredients() => selectedIngredients;
    }
}
