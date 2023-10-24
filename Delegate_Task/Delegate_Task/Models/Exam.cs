using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Task.Models
{
    internal class Exam
    {
        public string Subject { get; set; }

        public DateTime StartDate { get; set; }

        public TimeSpan ExamDuration { get; set; }

        public DateTime EndDate { get; }

        public Exam(string subject, DateTime startDate, TimeSpan examDuration)
        {
            Subject = subject;
			StartDate = startDate;
			ExamDuration = examDuration;
			EndDate= startDate.Add(examDuration);
        }

        public override string ToString()
        {
            return $"Subject: {Subject}, Start date: {StartDate}, Exam duration: {ExamDuration}, End date: {EndDate}";
        }
    }
}
