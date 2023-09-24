using Microsoft.AspNetCore.Mvc;
using WebServerAsp.Models;
using WebServerAsp.Repositories;

namespace WebServerAsp.Controllers;

[ApiController]
[Route("types-appeal")]
public class TypeAppealController: ControllerBase
{
    private readonly ITypesAppealRepository _typesAppealRepository;

    public TypeAppealController(ITypesAppealRepository typesAppealRepository)
    {
        _typesAppealRepository = typesAppealRepository;
    }
    
    [HttpGet]
    public IActionResult GetTypesAppeal()
    {
        // var types = _typesAppealRepository.GetAllTypesAppeal();
        // if (!types.Any())
        // {
        //     return BadRequest("Incorrect request");
        // }
        return Ok(/*new { typesAppeal = types }*/);
    }
}