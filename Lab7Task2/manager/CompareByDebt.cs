using System.Collections.Generic;
using Lab7Task2.models;

namespace Lab7Task2.manager
{
    public class CompareByDebt:IComparer<HousingBureau>
    {
        public int Compare(HousingBureau x, HousingBureau y)
        {
            return x.personDebt - y.personDebt;
        }
    }
}