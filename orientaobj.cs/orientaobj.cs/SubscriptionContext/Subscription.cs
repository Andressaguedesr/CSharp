using orientaobj.cs.SharedContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace orientaobj.cs.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }

       public DateTime? EndDate { get; set; }

        public bool IsActive => EndDate <= DateTime.Now;
    }
}
