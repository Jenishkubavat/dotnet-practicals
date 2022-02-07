using System;
namespace Indexers
{
    // example one
    /*public class TempRecord
    {
        // Array of temperature values
        float[] temps = new float[10]
        {
        56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
        61.3F, 65.9F, 62.1F, 59.2F, 57.5F
        };

        // To enable client code to validate input
        // when accessing your indexer.
        public int Length => temps.Length;

        // Indexer declaration.
        // If index is out of range, the temps array will throw the exception.
        public float this[int index]
        {
            get => temps[index];
            set => temps[index] = value;
        }
    }*/


    //example 3

    class DayCollection
    {
        string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };

        // Indexer with only a get accessor with the expression-bodied definition:
        public int this[string day] => FindDayIndex(day);

        private int FindDayIndex(string day)
        {
            for (int j = 0; j < days.Length; j++)
            {
                if (days[j] == day)
                {
                    return j;
                }
            }

            throw new ArgumentOutOfRangeException(
                nameof(day),
                $"Day {day} is not supported.\nDay input must be in the form \"Sun\", \"Mon\", etc");
        }
    }
}
