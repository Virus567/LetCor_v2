using Microsoft.EntityFrameworkCore;
using TouristСenterLibrary;

using WebServerAsp.Repositories;

namespace WebServerAsp.Services;

public class PsyhologistService:IPsyhologistRepository
{
    private readonly ApplicationContext _context;

    // public PsyhologistService(ApplicationContext context)
    // {
    //     _context = context;
    // }
    //
    // public Psychologist? GetPsychologistByUserId(int userId)
    // {
    //    return _context.Psychologist.Include(p => p.User).FirstOrDefault(p => p.User.ID == userId);
    // }
}