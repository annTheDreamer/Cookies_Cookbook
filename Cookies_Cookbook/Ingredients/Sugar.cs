using Cookies_Cookbook.Ingredients;

public class Sugar : Ingredient
{
    public override int Id => 5;
    public override string Name { get; } = "Sugar";
    public override string PrepareMethod => "";

    public override string Prepare() => "Add to other ingredients.";
}
