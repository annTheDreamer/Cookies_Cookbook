using Cookies_Cookbook.Ingredients;

public class Chocolate : Ingredient
{
    public override int Id => 4;
    public override string Name { get; } = "Chocolate";

    public override string PrepareMethod => "Melt in a water bath";
}
