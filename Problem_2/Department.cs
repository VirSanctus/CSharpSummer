using System;
namespace Problem_2
{
    public class Department
    {
        private string proffesion;
        private Worker[] listWorker;
        private int workerCount = 0;
        public Department(string Proffesion, Worker[] ListWorker)
        {
            this.proffesion = Proffesion;
            this.listWorker = ListWorker;
        }
        public string getProf()
        {
            return this.proffesion;
        }
        public Worker[] getList()
        {
            return this.listWorker;
        }
        public int getCount()
        {
            return this.workerCount;
        }
        public void addWorker(Worker worker)
        {
            if (this.workerCount < 30 && this.proffesion == worker.getProf())
            {
                this.listWorker[workerCount] = worker;
                this.workerCount++;
            }
            else Console.WriteLine("Department is full");
        }
    }
}
