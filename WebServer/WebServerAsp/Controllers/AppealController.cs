using Microsoft.AspNetCore.Mvc;

using WebServerAsp.Models;
using WebServerAsp.Repositories;

namespace WebServerAsp.Controllers;

[ApiController]
[Route("appeal")]
public class AppealController: ControllerBase
{
    private readonly IUserRepository _userRepository;
    private readonly IAppealRepository _appealRepository;
    private readonly ITypesAppealRepository _typesAppealRepository;
    private readonly IAnswerReposiroty _answerReposiroty;
    
    public AppealController(IUserRepository userRepository, IAppealRepository appealRepository,ITypesAppealRepository typesAppealRepository, IAnswerReposiroty answerReposiroty)
    {
        _userRepository = userRepository;
        _appealRepository = appealRepository;
        _typesAppealRepository = typesAppealRepository;
        _answerReposiroty = answerReposiroty;
    }
    
    [HttpGet("get-all-appeals")]
    public IActionResult GetAllAppeals()
    {
        // var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "user");
        // if (userId is null) return BadRequest("Incorrect token");
        // var user = _userRepository.GetUserByID(Convert.ToInt32(userId.Value));
        // if (user is null) return BadRequest("Incorrect user");
        // List<Appeal> appeals = new List<Appeal>();
        // if (user.IsPsychologist)
        // {
        //     appeals.AddRange(_appealRepository.GetAllNotAnsweredAppeals());
        // }
        // List<AppealModel> appealModels = new List<AppealModel>();
        // foreach (var a in appeals)
        // {
        //     appealModels.Add(new AppealModel(a));
        // }
        return Ok(/*new {appeals = appealModels}*/);
    }
    
    [HttpGet("history-appeal/{type}")]
    public IActionResult GetHistoryAppeal(string type)
    {
        // var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "user");
        // if (userId is null) return BadRequest("Incorrect token");
        // var user = _userRepository.GetUserByID(Convert.ToInt32(userId.Value));
        // if (user is null) return BadRequest("Incorrect user");
        // List<Appeal> appeals = _appealRepository.GetAllNotAnsweredAppealsByUserId(user.ID);
        // List<Answer> answers = _answerReposiroty.GetAnswersByUserId(user.ID);
        // var typesAppeals = _typesAppealRepository.GetAllTypesAppeal();
        //
        // List<PsixAnswerModel> answerModels = new List<PsixAnswerModel>();
        // List<AppealModel> appealModels = new List<AppealModel>();
        // foreach (var a in answers)
        // {
        //     answerModels.Add(new PsixAnswerModel(a));
        // }
        //
        // foreach (var a in appeals)
        // {
        //     appealModels.Add(new AppealModel(a));
        // }
        //
        // if (type != "*")
        // {
        //     answerModels = answerModels.Where(a => a.appeal.typeappeal ==type).ToList();
        //     appealModels = appealModels.Where(a => a.typeappeal == type).ToList();
        // }
        //     
        return Ok(/*new {answers = answerModels, appeals = appealModels, typesAppeal = typesAppeals }*/);//в каждом из answers содержится appealModel, appeals - это неотвеченные обращения
    }
   
    [HttpPost("add-appeal")]
    public IActionResult AddAppeal(PostAppealModel body)
    {
        // var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "user");
        // if (userId is null) return BadRequest("Incorrect token");
        // var user = _userRepository.GetUserByID(Convert.ToInt32(userId.Value));
        // if (user is null) return BadRequest("Incorrect user");
        //
        // if (body is null || body.text is null || body.typeappeal is null)
        // {
        //     return BadRequest("Incorrect request");
        // }
        // var typeAppeal = _typesAppealRepository.GetTypeAppealByName(body.typeappeal);
        // Appeal appeal = new Appeal(typeAppeal, user, body.text, false, DateTime.SpecifyKind(DateTime.Now.Date, DateTimeKind.Utc));
        // if (!_appealRepository.Add(appeal))
        // {
        //     return BadRequest("Incorrect request");
        // }
        return Ok(new {status = true});
    }
}