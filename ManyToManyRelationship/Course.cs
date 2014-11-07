using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyRelationship
{
    public class Course
    {
        public string Code { set; get; }
        public string Title { set; get; }

        public Course(string code, string title)
        {
            Code = code;
            Title = title;
        }
        public Course()
        { }
        
        public override string ToString()
        {
            return Title;
        }
    }
}
