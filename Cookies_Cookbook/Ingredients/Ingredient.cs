namespace Cookies_Cookbook.Ingredients
{
    public abstract class Ingredient
    {
        public abstract int Id { get; }
        public abstract string Name { get; }

        public abstract string PrepareMethod { get; }

        public virtual string Prepare()
        {
            string message = "Add to other ingredients.";
            if (string.IsNullOrWhiteSpace(PrepareMethod))
                return message;

            return $"{PrepareMethod}. {message}";
        }
    }
}
