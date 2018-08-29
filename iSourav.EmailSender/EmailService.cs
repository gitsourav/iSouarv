using iSourav.Domain.Interfaces.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSourav.EmailSender
{
    public class EmailService : INotificationProvider
    {
        ILoggerProvider _iLog;
        public EmailService(ILoggerProvider iLog)
        {
            _iLog = iLog;
        }
        public bool Send(string destination, string subject, string body)
        {
            //todo: send an email

            _iLog.Info("Email Sent to "+ destination);
            return true;
        }
    }
}
