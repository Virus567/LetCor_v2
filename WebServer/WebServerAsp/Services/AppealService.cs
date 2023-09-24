using Microsoft.EntityFrameworkCore;
using TouristСenterLibrary;

using WebServerAsp.Repositories;

namespace WebServerAsp.Services;

public class AppealService:IAppealRepository
{
    private readonly ApplicationContext _context;

    public AppealService(ApplicationContext context)
    {
        _context = context;
    }
    
    // public List<Appeal> GetAllNotAnsweredAppeals()
    // {
    //     return _context.Appeal.Include(a=>a.User).Include(a=>a.TypeAppeal).Where(a => !a.IsAnswered).ToList();
    // }
    //
    // public List<Appeal> GetAllNotAnsweredAppealsByUserId(int userId)
    // {
    //     return _context.Appeal.Include(a=>a.User).Include(a=>a.TypeAppeal).Where(a => !a.IsAnswered && a.User.ID == userId).ToList();
    //
    // }
    

    // public bool Add(Appeal appeal)
    // {
    //     try
    //     {
    //         _context.Appeal.Add(appeal);
    //         _context.SaveChanges();
    //         return true;
    //     }
    //     catch (Exception ex)
    //     {
    //         return false;
    //     }
    // }
    //
    // public Appeal? GetAppealById(int id)
    // {
    //     return _context.Appeal.Include(a=>a.User).Include(a=>a.TypeAppeal).FirstOrDefault(a => a.ID == id);
    // }
}