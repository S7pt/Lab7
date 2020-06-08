using System.Collections.Generic;
using Lab7Task2.models;

namespace Lab7Task2.manager
{
    public class CompareByHousesAndWorkers:IComparer<HousingBureau>
    {
        public int Compare(HousingBureau x, HousingBureau y)
        {
            int comparedBuildings = x.buildingAmount - y.buildingAmount;
            if (comparedBuildings != 0)
            {
                return comparedBuildings;
            }

            return x.workerAmount - y.workerAmount;
        }
    }
}