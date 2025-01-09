using Cookies_Cookbook.Ingredients;

public class Butter : Ingredient
{
    public override int Id => 3;
    public override string Name { get; } = "Butter";

    public override string PrepareMethod => "Melt on low heat";
}
