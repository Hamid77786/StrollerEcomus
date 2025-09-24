using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerEcomus.BLL.ViewModels
{
    public class FrequentlyQuestionViewModel
    {
        public int Id { get; set; }
        public string? QuestionTitle { get; set; }
        public string? QuestionContent { get; set; }
    }

    public class CreateFrequentlyQuestionViewModel
    {
        public string? QuestionTitle { get; set; }
        public string? QuestionContent { get; set; }
    }

    public class UpdateFrequentlyQuestionViewModel
    {
        public int Id { get; set; }
        public string? QuestionTitle { get; set; }
        public string? QuestionContent { get; set; }
    }
}
