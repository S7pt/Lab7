using System.Collections.Generic;
using Lab7Task2.manager;

namespace Lab7Task2.models
{
    public class HousingBureau
    {
        public string name { get; set; }
        public string address { get; set; }
        public string chiefSurname { get; set; }
        public int buildingAmount { get; set; }
        public int workerAmount { get; set; }
        public int personDebt { get; set; }

        public HousingBureau(string name, string address, string chiefSurname, int buildingAmount, int workerAmount, int personDebt)
        {
            this.name = name;
            this.address = address;
            this.chiefSurname = chiefSurname;
            this.buildingAmount = buildingAmount;
            this.workerAmount = workerAmount;
            this.personDebt = personDebt;
        }

        public void SortByDebt(List<HousingBureau> list)
        {
            CompareByDebt comparer=new CompareByDebt();
            list.Sort(comparer);
        }

        public void SortByHousesAndWorkers(List<HousingBureau> list)
        {
            CompareByHousesAndWorkers comparer=new CompareByHousesAndWorkers();
            list.Sort(comparer);
        }

        public override string ToString()
        {
            return name + " | " + address + " | " + chiefSurname + " | " + buildingAmount + " | " + workerAmount +  " | " + personDebt;
        }
    }
}