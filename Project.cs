using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace omagi_model
{
    public class Project
    {
        public String Fl_id {get;set;}
        public String GroupName { get; set; }
        public String ParentName { get; set; }
        public String MainGroupId { get; set; }
        public String MainGroupName { get; set; }
        public String ProvinceName { get; set; }
        public String DeptName { get; set; }
        public String ReportMember { get; set; }
        public String Fl_dept { get; set; }
        public String ParentId { get; set; }
        public int Level { get; set; }


    }
}
