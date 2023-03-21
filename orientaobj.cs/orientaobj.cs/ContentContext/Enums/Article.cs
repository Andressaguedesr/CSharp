using orientaobj.cs.NotificationContext;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;

namespace orientaobj.cs.ContentContext.Enums
{
    public class Article : Content
    {
        public Article(string title, string url)
            :base (title, url)
        { 
        }
    }
}
