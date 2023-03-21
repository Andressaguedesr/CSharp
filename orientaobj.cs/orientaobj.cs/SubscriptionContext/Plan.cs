using orientaobj.cs.SharedContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace orientaobj.cs.SubscriptionContext
{
    public class Plan : Base
    {
        public string Title { get; set; }

        public decimal Price { get; set; }

        public int Days { get; set; }
    }
}
