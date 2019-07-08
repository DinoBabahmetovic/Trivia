using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trivia.Models;

namespace Trivia.ViewModel
{
    public class RankingViewModel
    {
        public List<score> RankingsStandard { get; set; }
        public List<score> RankingsReverse { get; set; }
        public List<score> RankingsExtreme { get; set; }
    }
}