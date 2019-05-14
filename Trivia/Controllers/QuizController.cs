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
                //questionsList = dbModel.questions.ToList<question>();
                if (mode == "Standard") questionsList = dbModel.questions.Where(x => x.type == 1).ToList<question>();
                else questionsList = dbModel.questions.Where(x => x.type == 2).ToList<question>();
            }
            //if (mode == "Standard") questionsList.RemoveAll(s => s.type == 2);
            //else questionsList.RemoveAll(s => s.type == 1);


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

        [Route("quiz/ranking")]
        public ActionResult Ranking()
        {
            List<score> scoreList = new List<score>();
            using (DBModels dbModel = new DBModels())
            {
                scoreList = dbModel.scores.OrderBy(x => x.time).ToList<score>();
            }

            var viewModel = new RankingViewModel
            {
                Rankings = scoreList
            };

            return View(viewModel);
        }

        // POST: Quiz/SaveScore
        [HttpPost]
        public ActionResult SaveScore(string Player, int Time)
        {
            score scoreModel = new score
            {
                player = Player,
                time = Time
            };

            using (DBModels dbModel = new DBModels())
            {
                dbModel.scores.Add(scoreModel);
                dbModel.SaveChanges();
            }
            return RedirectToAction("Ranking");
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