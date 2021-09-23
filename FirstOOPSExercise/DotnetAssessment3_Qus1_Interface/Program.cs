using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAssessment3_Qus1_Interface
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Task perform by mentor's");
            Mentor mentor = new Mentor();
            mentor.assignWork();
            mentor.doWork();
            Console.WriteLine();
            Console.WriteLine("Task perform by TL's");
            TeamLeader teamLeader = new TeamLeader();
            teamLeader.assignWork();
            teamLeader.DoManagementTasks();
            Console.ReadLine();
        }
    }
    interface IAssignWork
    {
        void assignWork(); //Public and abstract by default
    }
    interface IDoWork
    {
        void doWork(); //Public and abstract by default
    }
    class Mentor : IAssignWork, IDoWork
    {
        public void assignWork()
        {
            Console.WriteLine("Mentor is responsible to assignwork and do mentoring for the menti's");
        }
        public void doWork()
        {
            Console.WriteLine("Mentor is also responsible to perform Some task.");
        }
    }
    class TeamLeader : IAssignWork
    {
        public void assignWork()
        {
            Console.WriteLine("Mentor is responsible to assignwork and do mentoring for the menti's");
        }
     public   void DoManagementTasks()
        {
            Console.WriteLine("Do not do work as simillar to Mentor,As he is having some other responsibilites.");
        }
    }
}
