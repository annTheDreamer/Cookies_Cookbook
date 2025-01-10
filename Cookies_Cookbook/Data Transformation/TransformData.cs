using Cookies_Cookbook.Data_Access;

namespace Cookies_Cookbook.Data_Transformation
{
    public static class TransformData
    {
        public static List<string> ListToString()
        {
            List<string> selectedIngredientsAsString = new List<string>();
            foreach (int ingredient in IngredientManagement.GetSelectedIngredients())
            {
                selectedIngredientsAsString.Add(ingredient.ToString());
            }
            return selectedIngredientsAsString;
        }
    }
}
