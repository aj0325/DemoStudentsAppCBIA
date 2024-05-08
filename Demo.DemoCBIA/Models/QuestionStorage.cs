using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DemoCBIA.Models
{
    public static class QuestionStorage
    {
        public static ObservableCollection<Question> Questions { get; set; } = new ObservableCollection<Question>();

        public static void AddQuestion(string studentId, string studentName, string questionText)
        {
            Questions.Add(new Question
            {
                StudentId = studentId,
                StudentName = studentName,
                QuestionText = questionText,
                Status = "Pending"
            });
        }
    }
}
