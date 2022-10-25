using Module1.models;

namespace Module1.services;

public interface IItemService
{
    Item FindItemById(long id);
    Item AddNewItem(Item item);
    Item UpdateItem(Item item);
}