namespace LearningCenter.Domain;

public class CategoryDomain : ICategoryService
{
    public List<string> getAll()
    {
        throw new NotImplementedException();
    }

    public string getCategoryById(int id)
    {
        return "body from Domain v2"+id.ToString();
    }

    public String createCategory(string name)
    {
        return "Se creó una categoría";
    }
}