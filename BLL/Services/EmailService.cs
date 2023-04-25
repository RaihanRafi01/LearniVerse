using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmailService
    {
        public static bool SendEmail(int id)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(100000, 1000000);
            var data = DataAccessFactory.TeacherData().Get(id);
            string email = data.Email;
            //string email = "r.rafi.aiub@gmail.com";
            if (email == null)
            {
                return false;
            }

            var fromAddress = new MailAddress("dotnet193@gmail.com", "Zero Hunger");
            var toAddress = new MailAddress(email, "xyz");
            const string fromPassword = "nocwlctpslfhwvov";
            const string subject = "Reset Password Email";
            string body = "Your OTP is : " + randomNumber;
            

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
                
            }
            
            return true;

        }
    }
}
