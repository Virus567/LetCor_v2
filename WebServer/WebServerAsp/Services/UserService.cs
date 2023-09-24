using TouristСenterLibrary;

using WebServerAsp.Models;
using WebServerAsp.Repositories;

namespace WebServerAsp.Services;

public class UserService:IUserRepository
{
    private readonly ApplicationContext _context;

    public UserService(ApplicationContext context)
    {
        _context = context;
    }
    // public User? GetUserByID(int id)
    // {
    //     return _context.User.FirstOrDefault(u => u.ID == id);
    // }
    //
    // public User? GetUserByEmail(string email)
    // {
    //     return _context.User.FirstOrDefault(u => u.Email == email);
    // }
    //
    // public bool RegisterUser(RegModel body)
    // {
    //      User? user;
    //         if (body.surname != null && body.name != null && body.email!=null&& body.password !=null)
    //         {
    //             user = new User(body!.surname, body.name, body.email, body.password, false);
    //             try
    //             {
    //                 _context.User.Add(user);
    //                 _context.SaveChanges();
    //                 return true;
    //             }
    //             catch (Exception ex)
    //             {
    //                 return false;
    //             }
    //         }
    //         return false;
    //
    // }

    // public User? GetUserAuth(string email, string password)
    // {
    //     try
    //     {
    //         return Context.db.User.FirstOrDefault(c => c.Email == email && c.Pass == password);
    //     }
    //     catch {
    //         return null;
    //     }
    // }
    
}