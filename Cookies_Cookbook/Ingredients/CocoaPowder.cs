using Cookies_Cookbook.Ingredients;

public class CocoaPowder : Ingredient
{
    public override int Id => 8;
    public override string Name { get; } = "Cocoa powder";
    public override string PrepareMethod => "";

    public override string Prepare() => "Add to other ingredients.";
}
