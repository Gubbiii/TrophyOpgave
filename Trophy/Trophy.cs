using System.Diagnostics;
using System.Security.Cryptography;

namespace TrophyProgram
{
    public class Trophy
    {
        private int year;
        private string competition;
        private int id;
        private static int nextId = 0;

        public Trophy()
        {
            id = nextId++;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        public string Competition
        {
            get => competition;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                    throw new ArgumentException("Competition must be at least 3 characters long.");
                competition = value;
            }
        }

        public int Year
        {
            get => year;
            set
            {
                if (value < 1970 || value > 2025)
                    throw new ArgumentOutOfRangeException("Year must be between 1970 and 2025.");
                year = value;
            }
        }

        public override string ToString()
        {
            return $"Year: {year}, Compitition: {competition}, Id: {id}";
        }

    }
}
