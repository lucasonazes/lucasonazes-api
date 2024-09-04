public interface IUserRepo
{
    Task<List<UserModel>> SearchAllUsers();
    Task<UserModel> SearchUsersById(int id);
    Task<UserModel> Add(UserModel user);
    Task<UserModel> Update(UserModel user, int id);
    Task<bool> Delete(int id);
}