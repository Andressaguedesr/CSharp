using System;
using System.Collections.Generic;
using System.Text;
using orientaobj.cs.SharedContext;

namespace orientaobj.cs.ContentContext.Enums
{
    public class Lecture : Base
    {
        public int Order { get; set; }

        public string Title { get; set; }

        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }
    }
}
