using System;
namespace Problem_1
{
    public class Cables
    {
        private string name;
        private Client[] clientList;
        public Cables(string Name, Client[] ClientList)
        {
            this.name = Name;
            this.clientList = ClientList;
        }
        //Getters
        public string getName()
        {
            return this.name;
        }
        public Client[] getClientList()
        {
            return this.clientList;
        }
        public string[] CheckClient(Cables cab1)
        {
            string[] badClient = new string[this.getClientList().Length];
            for (int i = 0; i < cab1.getClientList().Length; i++)
            {
                if (cab1.getClientList()[i].getName() == this.name)
                {
                    badClient[i] = this.name;
                }
            }
            return badClient;
        }
    }
}