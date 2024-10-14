using Todoran_Iulia_Lab2.Data;

namespace Todoran_Iulia_Lab2.Models
{
    public class BookCategoriesPageModel
    {
        public List<AssignedCategoryData> AssignedCategoriesDataList;

        public void PopulateAssignedCategoryData(Todoran_Iulia_Lab2Context context, Book book)
        {
            var allCategories = context.Category;
            var bookCategories = new HashSet<int>(book.BookCategories.Select(c => c.CategoryID)); //
        AssignedCategoriesDataList = new List<AssignedCategoryData>();
            foreach (var cat in allCategories) {
                AssignedCategoriesDataList.Add(new AssignedCategoryData)
                    {

                }
        }
    }
}
