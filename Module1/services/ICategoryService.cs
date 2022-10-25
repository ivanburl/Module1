using Module1.models;

namespace Module1.services;

public interface ICategoryService
{
  Category FindCategoryById(long id);
  Category AddNewCategory(Category category);
  Category UpdateCategory(Category category);
}