using System;
namespace Problem_1
{
    public class Client
    {
        private int id;
        private string name;
        private int phonenumber;
        private string[] channels;

        public Client(int Id, string Name, int Phonenumber, string[] Channels)
        {
            this.id = Id;
            this.name = Name;
            this.phonenumber = Phonenumber;
            this.channels = Channels;
        }
        //Getters for class
        public int getId()
        {
            return this.id;
        }
        public string getName()
        {
            return this.name;
        }
        public int getNumber()
        {
            return this.phonenumber;
        }
        public string[] getChannels()
        {
            return this.channels;
        }
        //Setters for class
        public void setId(int newId)
        {
            this.id = newId;
        }
        public void setName(string newName)
        {
            this.name = newName;
        }
        public void setNumber(int newNumber)
        {
            this.phonenumber = newNumber;
        }
        public void setChannels(string[] newList)
        {
            this.channels = newList;
        }


    }
}
