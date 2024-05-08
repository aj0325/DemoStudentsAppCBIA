using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.ApiClient.Models.ApiModels
{
    public class Question
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string? QuestionAsked { get; set; }
        public DateTime Date { get; set; }
        public string? Answer { get; set; }
        public bool Solved { get; set; }

    }
}
