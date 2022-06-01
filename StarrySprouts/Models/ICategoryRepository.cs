namespace StarrySprouts.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<CategoryModel> GetAllCategories { get; }
    }
}
