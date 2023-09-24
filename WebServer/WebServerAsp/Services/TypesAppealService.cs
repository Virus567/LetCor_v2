using TouristСenterLibrary;

using WebServerAsp.Repositories;

namespace WebServerAsp.Services;

public class TypesAppealService:ITypesAppealRepository
{
    private readonly ApplicationContext _context;

    public TypesAppealService(ApplicationContext context)
    {
        _context = context;
    }
    
    // public List<TypeAppeal> GetAllTypesAppeal()
    // {
    //    return _context.TypeAppeal.ToList();
    // }
    //
    // public TypeAppeal? GetTypeAppealByName(string name)
    // {
    //     return _context.TypeAppeal.FirstOrDefault(t => t.TypeName == name);
    // }
}