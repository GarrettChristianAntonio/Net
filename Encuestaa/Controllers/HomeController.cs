using Encuestaa.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;

namespace Encuestaa.Controllers
{
    public class HomeController : Controller
    {
        private IPollResultService _pollResultService;
        public HomeController(IPollResultService pollResultService) 
        {
            _pollResultService = pollResultService;
        }
        public IActionResult Index()
        {
            if (Request.Query.ContainsKey("submitted"))
            {
                StringBuilder resultado = new StringBuilder();
                SortedDictionary<Deporte, int> voteList = _pollResultService.GetVoteResult();
                foreach (KeyValuePair<Deporte, int> item in voteList)
                {
                     resultado.Append($"Nombre deporte: {item.Key}, Votos: {item.Value} {Environment.NewLine} ");
                }
                return Content(resultado.ToString());
            }
            else
            {
                return RedirectToAction("poll-questions.html");
            }            
        }
    }
}
