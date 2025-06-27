using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class Notification
    {
        public virtual string Send()
        {
            return "Sending notification...";
        }
    }

    public class EmailNotification : Notification
    {
        public override string Send()
        {
            return "Email notification sent.";
        }
    }

    public class SMSNotification : Notification
    {
        public override string Send()
        {
            return "SMS notification sent.";
        }
    }
}
