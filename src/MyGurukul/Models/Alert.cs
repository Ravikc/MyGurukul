using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGurukul.Models
{
    public enum AlertType { Events, News, Birthday, Notice, ExamNotice };

    public class Alert
    {
        public int AlertID { get; set; }
        public AlertType AlertType { get; set; }
        public string Content { get; set; }
    }
}
