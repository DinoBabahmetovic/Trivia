using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trivia.Models;

namespace Trivia.ViewModel
{
    public class QuestionViewModel
    {
        public List<Question> Questions { get; set; }
        public string Mode { get; set; }
    }
}