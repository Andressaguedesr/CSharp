using System;
using System.Collections.Generic;
using System.Text;
using orientaobj.cs.SharedContext;

namespace orientaobj.cs.ContentContext.Enums
{

    public class Module : Base
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }

        public string Title { get; set; }

        public IList<Lecture> Lectures { get; set; }
    }


}
