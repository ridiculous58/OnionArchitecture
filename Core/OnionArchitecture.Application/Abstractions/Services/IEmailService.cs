using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Abstractions.Services
{
    public interface IEmailService
    {
        void Send(string from,string to,string message);
    }
}
