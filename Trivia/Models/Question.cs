using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trivia.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RightAnswer { get; set; }
        public string WrongAnswer { get; set; }
    }
}