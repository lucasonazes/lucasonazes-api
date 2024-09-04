
public class UserRepo : IUserRepo
{
    public Task<UserModel> SearchUsersById(int id)
    {
        throw new NotImplementedException();
    }
    public Task<List<UserModel>> SearchAllUsers()
    {
        throw new NotImplementedException();
    }

    public Task<UserModel> Add(UserModel user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<UserModel> Update(UserModel user, int id)
    {
        throw new NotImplementedException();
    }
}