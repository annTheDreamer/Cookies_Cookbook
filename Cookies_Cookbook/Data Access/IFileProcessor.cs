namespace Cookies_Cookbook.Data_Access
{
    public interface IFileProcessor
    {
        List<List<string>> Read(string filePath);
        void Write(string filePath, List<string> selectedIngredients);
    }
}
