using System;

namespace Problem_1
{
    class MainClass
    {
		public static bool CheckChannel(Client A, string cname)
		{
			bool a = false;
            for (int i = 0; i < A.getChannels().Length; i++)
			{
                if (A.getChannels()[i] == cname)
					a = true;
			}
			return a;

		}
        public static void Advertise(Cables A)
        {
            Console.WriteLine("What channel to advertise?");
            string adChannel = Console.ReadLine();
            for (int i = 0; i < A.getClientList().Length; i++)
            {
                for (int j = 0; i < A.getClientList()[i].getChannels().Length; j++)
                {
                    if (A.getClientList()[i].getChannels()[j] != adChannel)
                    {
                        Console.WriteLine(A.getClientList()[i].getNumber());
                    }
                    else Console.WriteLine("Client already has the channel");
                }
            }
        }

        public static void Main(string[] args)
        {
        }
    }
}
