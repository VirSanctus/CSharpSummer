using System;
namespace Problem_2
{
    public class Company
    {
        private string name;
        private Department[] depList;
        public Company(string Name, Department[] DepList)
        {
            this.name = Name;
            this.depList = DepList;
        }
        public void workerAgeRemove()
        {
            for (int i = 0; i < this.depList.Length; i++)
            {
                for (int j = 0; j < this.depList[i].getList().Length; j++)
                {
                    if (this.depList[i].getList()[j].getYears() < 15)
                    {
                        this.depList[i].getList()[j] = null;
						if (j == this.depList[i].getList().Length - 1)
						{
							return;
						}
                        else
                        {
                            for (int k = j+1; k < this.depList[i].getList().Length;k++)
                            {
                                this.depList[i].getList()[k] = this.depList[i].getList()[k - 1];
                            }
                        }
                    }
                }
            }
        }
    }
}
