using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_In_Form
{
    public class ScheduleEntry
    {
        public string CourseName { get; set; }
        public string CourseTeacher { get; set; }
        public string LectureType { get; set; }
        public double StartTime { get; set; }
        public double FinishTime { get; set; }
        public List<string> Days { get; set; }
    }
}
