using System;
namespace Problem_2
{
    public class Worker
    {
        private int id;
        private string name;
        private int numYears;
        private string proffesion;
        public Worker(int Id, string Name, int NumYears, string Proffesion)
        {
            this.id = Id;
            this.name = Name;
            this.numYears = NumYears;
            this.proffesion = Proffesion;
        }
        public int getId()
        {
            return this.id;
        }
        public string getName()
        {
            return this.name;
        }
        public int getYears()
        {
            return this.numYears;
        }
        public string getProf()
        {
            return this.proffesion;
        }
    }
}
