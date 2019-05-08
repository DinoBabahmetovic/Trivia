using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trivia.Models;
using Trivia.ViewModel;

namespace Trivia.Controllers
{
    public class QuizController : Controller
    {

        // GET: Quiz
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: Quiz/Play
        [Route("quiz/play/{mode}")]
        public ActionResult Play(string mode)
        {
            List<question> questionsList = new List<question>();
            using(DBModels dbModel = new DBModels())
            {
                questionsList = dbModel.questions.ToList<question>();
            }
            if (mode == "Standard") questionsList.RemoveAll(s => s.type == 2);
            else questionsList.RemoveAll(s => s.type == 1);


            var viewModel = new QuestionViewModel
            {
                Questions = questionsList,
                Mode = mode
            };

            return View(viewModel);
        }

        // GET: Customers/Details/{Id}
        [Route("quiz/end/{result}")]
        public ActionResult End(int result)
        {
            ViewBag.Message = result;
            return View();
        }


        /*[HttpPost]
        public ActionResult UpdateResult(string res)
        {
            //return RedirectToAction("End", "Quiz", result);
            result = res;
            return Content(res);
        }*/

        /*[HttpPost]
        public ActionResult End(string result)
        {
            ViewBag.Result = result;
            return PartialView();
        }*/
    }
}