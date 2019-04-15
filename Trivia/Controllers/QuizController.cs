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
                new Question {Id = 1, Name = "The art of growing small ornamental trees is called what?", WrongAnswer = "Karaoke", RightAnswer = "Bonsai"},
                new Question {Id = 2, Name = "Who was the mouse, Tom or Jerry?", WrongAnswer = "Tom", RightAnswer = "Jerry"},
                new Question {Id = 3, Name = "Which of these are tourist attractions in Egypt?", WrongAnswer = "Spheres", RightAnswer = "Pyramids"},
                new Question {Id = 4, Name = "FIFA is the rulling international body of which sport?", WrongAnswer = "Swimming", RightAnswer = "Football"},
                new Question {Id = 5, Name = "What does a white flag generally mean?", WrongAnswer = "Attack", RightAnswer = "Surrender"},
                new Question {Id = 6, Name = "Which of these is not a European capital city?", WrongAnswer = "Paris", RightAnswer = "Tokyo"},
                new Question {Id = 7, Name = "What is missing from this movie title: \"The Lion ____\"?", WrongAnswer = "Queen", RightAnswer = "King"},
                new Question {Id = 8, Name = "In which game do you buy and sell properties, avoid jail time, and draw chance cards?", WrongAnswer = "Risk", RightAnswer = "Monopoly"},
                new Question {Id = 9, Name = "In what comedy is a child accidentaly left behind at home, while his family goes on vacation?", WrongAnswer = "Crazy, Stupid, Love", RightAnswer = "Home Alone"},
                new Question {Id = 10, Name = "Which of these animals is not a bird?", WrongAnswer = "Parrot", RightAnswer = "Zebra"},
                new Question {Id = 11, Name = "Who is considered the \"father\" of western medicine?", WrongAnswer = "Donald Trump", RightAnswer = "Hippocrates"},
                new Question {Id = 12, Name = "I am a reptile that has the ability to change color. Who am I?", WrongAnswer = "Komodo dragon", RightAnswer = "Chameleon"},
                new Question {Id = 13, Name = "What is missing from this book title: \"_______ and the Chocolate Factory\"?", WrongAnswer = "Jimmy", RightAnswer = "Charlie"},
                new Question {Id = 14, Name = "What was da Vinci's first name?", WrongAnswer = "Mona", RightAnswer = "Leonardo"},
                new Question {Id = 15, Name = "According to the famous phrase, who is a man's best friend?", WrongAnswer = "Cat", RightAnswer = "Dog"},
                new Question {Id = 16, Name = "Which tech company makes the Galaxy range of mobile phones?", WrongAnswer = "Apple", RightAnswer = "Samsung"},
                new Question {Id = 17, Name = "Which country's flag has more stars?", WrongAnswer = "Portugal", RightAnswer = "United States"},
                new Question {Id = 18, Name = "World champion sprinter Usain Bolt is from which nation?", WrongAnswer = "Ukraine", RightAnswer = "Jamaica"},
                new Question {Id = 19, Name = "Roughly what shape are most planets?", WrongAnswer = "Pyramids", RightAnswer = "Spheres"},
                new Question {Id = 20, Name = "What type of creature is a gecko?", WrongAnswer = "Insect", RightAnswer = "Lizard"}
            };

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
            var viewModel = new QuestionViewModel
            {
                Questions = questions,
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