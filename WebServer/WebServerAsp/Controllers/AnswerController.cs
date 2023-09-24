using System.Net;
using System.Net.Mail;
using ExcelLibrary;
using Microsoft.AspNetCore.Mvc;
using WebServerAsp.Models;
using WebServerAsp.Repositories;

namespace WebServerAsp.Controllers;

[ApiController]
[Route("answers")]
public class AnswerController: ControllerBase
{
    private readonly IUserRepository _userRepository;
    private readonly IPsyhologistRepository _psyhologistRepository;
    private readonly IAnswerReposiroty _answerReposiroty;
    private readonly IAppealRepository _appealRepository;

    public AnswerController(IUserRepository userRepository, IAnswerReposiroty answerReposiroty, IPsyhologistRepository psyhologistRepository, IAppealRepository appealRepository)
    {
        _userRepository = userRepository;
        _answerReposiroty = answerReposiroty;
        _psyhologistRepository = psyhologistRepository;
        _appealRepository = appealRepository;
    }
    
    [HttpGet("get-all-answers")]
    public IActionResult GetAllAnswers()
    {
        // var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "user");
        // if (userId is null) return BadRequest("Incorrect token");
        // var user = _userRepository.GetUserByID(Convert.ToInt32(userId.Value));
        // if (user is null) return BadRequest("Incorrect user");
        // var psychologist = _psyhologistRepository.GetPsychologistByUserId(user.ID);
        // List<Answer> answers = _answerReposiroty.GetAnswersByPsychologistId(psychologist.ID);
        // List<PsixAnswerModel> answerModels = new List<PsixAnswerModel>();
        // foreach (var a in answers)
        // {
        //     answerModels.Add(new PsixAnswerModel(a));
        // }
        //
        return Ok(/*new {answers = answerModels}*/);
    }
    
    [HttpPost("add-answer")]
    public IActionResult AddAnswer(PsixPostAnswerModel body)
    {
        // var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "user");
        // if (userId is null) return BadRequest("Incorrect token");
        // var user = _userRepository.GetUserByID(Convert.ToInt32(userId.Value));
        // if (user is null) return BadRequest("Incorrect user");
        //
        // if (body is null || body.appeal is null || body.answertext is null)
        // {
        //     return BadRequest("Incorrect request");
        // }
        // var appeal = _appealRepository.GetAppealById(body.appeal.id);
        // var psychologist = _psyhologistRepository.GetPsychologistByUserId(user.ID);
        // appeal.IsAnswered = true;
        //     
        // Answer answer = new Answer(appeal, body.answertext, psychologist,DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc));
        // if (!_answerReposiroty.Add(answer))
        // {
        //     return BadRequest("Incorrect request");
        // }
        // CommitMessage(body.answertext, appeal.User);
        return Ok(new {status = true});
    }

    [HttpPost("report")]
    public IActionResult GetReport(DatesModel body)
    {
        // var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "user");
        // if (userId is null) return BadRequest("Incorrect token");
        // var user = _userRepository.GetUserByID(Convert.ToInt32(userId.Value));
        // if (user is null) return BadRequest("Incorrect user");
        //
        // if (body is null || body.startdate is null || body.finishdate is null)
        // {
        //     return BadRequest("Incorrect request");
        // }
        // var psychologist = _psyhologistRepository.GetPsychologistByUserId(user.ID);
        // List<Answer> answers = _answerReposiroty.GetAnswersByPsychologistId(psychologist.ID);
        // answers = answers.Where(a => a.DateTime >= DateTime.Parse(body.startdate) && a.DateTime <= DateTime.Parse(body.finishdate)).ToList();
        // string path = Directory.GetCurrentDirectory();
        // string filePath = Path.Combine(path,$"Report.xlsx");
        // using (var excel = new ExcelHelper())
        // {
        //     try
        //     {
        //          
        //         if (excel.Open(filePath))
        //         {
        //             excel.SetAnswers(answers, body.startdate, body.finishdate);
        //             excel.Save();
        //             excel.Dispose();
        //         }
        //     }
        //     catch (Exception ex) { }
        // }
        //
        // var from = new MailAddress("tourist-center-vyatsu@mail.ru", "Администрация туристического центра");
        // var to = new MailAddress(user.Email, "Пользователь");
        // var msg = new MailMessage(from, to);
        // msg.Subject = "Отчет по обращениям";
        // msg.Attachments.Add(
        //     new Attachment(filePath));
        // msg.Body = "Сформирован отчет по обработанным обращениям с " +body.startdate+" по " + body.startdate+".";
        // using (var smtp = new SmtpClient("smtp.mail.ru", 587))
        // {
        //     smtp.Credentials = new NetworkCredential("tourist-center-vyatsu@mail.ru", "PgbQ8YpGhzZzuWMJkU4p");
        //     smtp.EnableSsl = true;
        //     smtp.Send(msg);
        // }
        return Ok(new {status = true});
    }
    
    public static void CommitMessage(/*string answer, User user*/)
    {
        // var from = new MailAddress("tourist-center-vyatsu@mail.ru", "Администрация туристического центра");
        // var to = new MailAddress(user.Email, "Пользователь");
        //
        // var msg2 = new MailMessage(from, to);
        // msg2.Subject = "Ответ от психологического центра";
        // msg2.Body = $"Добрый день,{user.Surname} {user.Name}, вам пришел ответ на ваше обращение : {answer}";
        // msg2.IsBodyHtml = true;
        // using (var smtp = new SmtpClient("smtp.mail.ru", 587))
        // {
        //     smtp.Credentials = new NetworkCredential("tourist-center-vyatsu@mail.ru", "PgbQ8YpGhzZzuWMJkU4p");
        //     smtp.EnableSsl = true;
        //     smtp.Send(msg2);
        // }
    }
}