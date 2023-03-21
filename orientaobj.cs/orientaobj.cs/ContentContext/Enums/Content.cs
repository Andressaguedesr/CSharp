using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using orientaobj.cs.SharedContext;

namespace orientaobj.cs.ContentContext.Enums
{
    public class Content : Base
    {

        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }

        

        public string Title { get; set; }

        public string Url { get; set; }
    }
}
