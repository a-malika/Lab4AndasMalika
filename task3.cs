using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3 задание
//Interface Segregation Principle
namespace Laboratory4
{
    public interface IWorkerWork
    {
        void Work();
    }
    public interface IWorkerEat
    {
        void Eat();
    }
    public interface IWorkerSleep
    {
        void Sleep();
    }
    public class HumanWorker : IWorkerWork, IWorkerEat, IWorkerSleep
    {
        public void Work()
        {
            // Логика работы
        }

        public void Eat()
        {
            // Логика питания
        }

        public void Sleep()
        {
            // Логика сна
        }
    }
    public class RobotWorker : IWorkerWork
    {
        public void Work()
        {
            // Логика работы
        }
    }

}
