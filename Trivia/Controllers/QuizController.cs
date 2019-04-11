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
        List<Question> questions = new List<Question>
            {
                new Question {Id = 1, Name = "The art of growing small ornamental trees is called what?", RightAnswer = "Karaoke", WrongAnswer = "Bonsai"},
                new Question {Id = 2, Name = "Who was the mouse, Tom or Jerry?", RightAnswer = "Tom", WrongAnswer = "Jerry"},
                new Question {Id = 3, Name = "Which of these are tourist attractions in Egypt?", RightAnswer = "Cubes", WrongAnswer = "Pyramids"},
                new Question {Id = 4, Name = "FIFA is the rulling international body of which sport?", RightAnswer = "Swimming", WrongAnswer = "Soccer"},
                new Question {Id = 5, Name = "What does a white flag generally mean?", RightAnswer = "Attack", WrongAnswer = "Surrender"},
                new Question {Id = 6, Name = "Which of these is not a European capital city?", RightAnswer = "Paris", WrongAnswer = "Tokyo"},
                new Question {Id = 7, Name = "What is missing from this movie title: \"The Lion ____\"?", RightAnswer = "Queen", WrongAnswer = "King"},
                new Question {Id = 8, Name = "In which game do you buy and sell properties, avoid jail time, and draw chance cards?", RightAnswer = "Risk", WrongAnswer = "Monopoly"},
                new Question {Id = 9, Name = "In what comedy is a child accidentaly left behind at home, while his family goes on vacation?", RightAnswer = "Crazy, Stupid, Love", WrongAnswer = "Home Alone"},
                new Question {Id = 10, Name = "Which od these animals is not a bird?", RightAnswer = "Parrot", WrongAnswer = "Zebra"}
            };

        string result = "jebote";

        // GET: Quiz
        [Route("")]
        public ActionResult Home()
        {
            return View();
        }

        // GET: Quiz/Play
        [Route("quiz/play")]
        public ActionResult Play()
        {
            var viewModel = new QuestionViewModel
            {
                Questions = questions
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