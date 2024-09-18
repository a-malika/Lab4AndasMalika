using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4 задание
//Dependency-Inversion Principle
namespace Laboratory4
{
    public interface INotification
    {
        void Send(string message);
    }
    public class EmailService : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Отправка Email: {message}");
        }
    }

}
