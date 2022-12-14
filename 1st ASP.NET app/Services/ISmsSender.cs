using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _st_ASP.NET_app.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
