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
        [Route("quiz/play/{mode}/{language}")]
        public ActionResult Play(string language, string mode)
        {
            List<question> questionsList = new List<question>();
            using(DBModels dbModel = new DBModels())
            {
                //questionsList = dbModel.questions.ToList<question>();
                if (mode == "Standard") questionsList = dbModel.questions.Where(x => (x.type == 1 && x.language == language)).ToList<question>();
                else questionsList = dbModel.questions.Where(x => (x.type == 2 && x.language == language)).ToList<question>();
            }

            var viewModel = new QuestionViewModel
            {
                Questions = questionsList,
                Mode = mode
            };

            return View(viewModel);
        }

        // GET: Customers/Details/{Id}
        [Route("quiz/end/{mode}/{result}")]
        public ActionResult End(string mode, int result)
        {
            ViewBag.Message = result;
            return View();
        }

        [Route("quiz/ranking")]
        public ActionResult Ranking()
        {
            List<score> scoreListStandard = new List<score>();
            List<score> scoreListReverse = new List<score>();
            using (DBModels dbModel = new DBModels())
            {
                scoreListStandard = dbModel.scores.Where(x => x.mode == 1).OrderBy(x => x.time).ToList<score>();  //OrderBy(x => x.time).ToList<score>();
                scoreListReverse = dbModel.scores.Where(x => x.mode == 2).OrderBy(x => x.time).ToList<score>();
            }

            var viewModel = new RankingViewModel
            {
                RankingsStandard = scoreListStandard,
                RankingsReverse = scoreListReverse
            };

            return View(viewModel);
        }

        // POST: Quiz/SaveScore
        [HttpPost]
        public ActionResult SaveScore(string Player, int Time, int Mode)
        {
            score scoreModel = new score
            {
                player = Player,
                time = Time,
                mode = Mode
            };

            using (DBModels dbModel = new DBModels())
            {
                dbModel.scores.Add(scoreModel);
                dbModel.SaveChanges();
            }
            return RedirectToAction("Ranking");
        }
    }
}