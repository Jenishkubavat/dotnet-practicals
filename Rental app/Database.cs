/*using System;

public class Vehicalsdatabase
{

    enum vehicals
    {
        indica=0,
        qualis=1,
        harlyDavidson=3,
        mBenzEclass=4
    }
   public Dictionary<int, string> listofAvableVehicals = new Dictionary<int, string>();
   public  List<int> inMantancances = new List<int>();
   public  List<int> rentedvehicals = new List<int>();
   public Vehicalsdatabase()
    {
        int n = 4;
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            int count = random.Next(1, 20);
            for (int j = 0; j < count ; j++)
            {
                listofAvableVehicals.Add(j,((vehicals)i).ToString());
            }
        }

    }
}
*/