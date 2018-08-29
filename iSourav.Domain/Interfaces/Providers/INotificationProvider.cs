using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSourav.Domain.Interfaces.Providers
{
    public interface INotificationProvider
    {
        bool Send(string destination, string subject, string message);
    }
}
