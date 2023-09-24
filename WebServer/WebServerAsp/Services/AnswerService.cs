using Microsoft.EntityFrameworkCore;
using TouristСenterLibrary;

using WebServerAsp.Repositories;

namespace WebServerAsp.Services;

public class AnswerService:IAnswerReposiroty
{
    private readonly ApplicationContext _context;

    public AnswerService(ApplicationContext context)
    {
        _context = context;
    }
    
    // public List<Answer> GetAnswersByPsychologistId(int psychologistId)
    // {
    //     return _context.Answer.Include(a => a.Appeal)
    //         .ThenInclude(a => a.User)
    //         .Include(a => a.Appeal)
    //         .ThenInclude(a => a.TypeAppeal)
    //         .Include(a=>a.Psychologist)
    //         .ThenInclude(a => a.User)
    //         .Where(a => a.Psychologist.ID == psychologistId).ToList();
    // }

    // public List<Answer> GetAnswersByUserId(int userId)
    // {
    //     return _context.Answer.Include(a => a.Appeal).ThenInclude(a => a.User).Where(a => a.Appeal.User.ID == userId).ToList();
    //
    // }

    // public bool Add(Answer answer)
    // {
    //     try
    //     {
    //         _context.Answer.Add(answer);
    //         _context.SaveChanges();
    //         return true;
    //     }
    //     catch (Exception ex)
    //     {
    //         return false;
    //     }
    // }
}