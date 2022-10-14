namespace LearningCenter.Domain;

public interface ICategoryService
{
    List<string> getAll();
    string getCategoryById(int id);
    String createCategory(string name);
}