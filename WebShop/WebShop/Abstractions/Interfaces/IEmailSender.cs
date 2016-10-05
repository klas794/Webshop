using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Abstractions.Interfaces
{
    interface IEmailSender
    {
        SmtpClient PrepareLocalSender();
        void DeliverEmail(string subject, string message);
    }
}
