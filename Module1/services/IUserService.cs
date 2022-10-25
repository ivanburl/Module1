using Module1.models;

namespace Module1.services;

public interface IUserService
{
    User FindById(long id);
    User AddNewUser(User user);
    User UpdateUSer(User user);
}