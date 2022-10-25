using Module1.models;

namespace Module1.services;

public interface IOrderService
{
    Order FindOrderById(long id);
    Order AddNewOrder(Order order);
    Order UpdateOrder(Order order);
    bool PayForOrder(Order order, BankCredentials bankCredentials);
    void NotifyBuyer(Order order);
}