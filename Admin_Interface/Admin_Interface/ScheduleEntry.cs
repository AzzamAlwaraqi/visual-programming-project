using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Interface
{
    public class ScheduleEntry
    {
        public string CourseName { get; set; }
        public string CourseTeacher { get; set; }
        public string LectureType { get; set; }
        public int StartTime { get; set; }
        public int FinishTime { get; set; }
        public List<string> Days { get; set; }
    }
}
