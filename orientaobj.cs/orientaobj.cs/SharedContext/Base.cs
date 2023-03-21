using orientaobj.cs.NotificationContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace orientaobj.cs.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
