using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TrophyProgram
{
    public class TrophiesRepository
    {
        private List<Trophy> trophies = new List<Trophy>();
        private int nextId = 1;

        public TrophiesRepository()
        {
            trophies.Add(new Trophy { ID = nextId++, Competition = "Fodbold", Year = 2020 });
            trophies.Add(new Trophy { ID = nextId++, Competition = "Svømning", Year = 2018 });
            trophies.Add(new Trophy { ID = nextId++, Competition = "Skydning", Year = 2016 });
            trophies.Add(new Trophy { ID = nextId++, Competition = "Bodybuilding", Year = 2019 });
            trophies.Add(new Trophy { ID = nextId++, Competition = "Fletning", Year = 2021 });
        }

        public List<Trophy> Get(int? year = null, bool sortByCompetition = false, bool sortByYear = false)
        {
            var result = trophies.ToList();

            if (year.HasValue)
            {
                result = result.Where(t => t.Year == year.Value).ToList();
            }

            if (sortByCompetition)
            {
                result = result.OrderBy(t => t.Competition).ToList();
            }
            else if (sortByYear)
            {
                result = result.OrderBy(t => t.Year).ToList();
            }

            return result;
        }

        public Trophy? GetById(int id)
        {
            return trophies.FirstOrDefault(t => t.ID == id);
        }

        public Trophy Add(Trophy trophy)
        {
            trophy.ID = nextId++;
            trophies.Add(trophy);
            return trophy;
        }

        public string? Remove(int ID)
        {
            foreach (Trophy trophy in trophies.ToList())
            {
                if (trophy.ID == ID)
                {
                    Console.WriteLine($"You're deleting {trophy}");
                    trophies.RemoveAll(Trophy => Trophy.ID == ID);
                    return "Object has been deleted.";
                }
                return null;
            }
            return null;
        }

        public Trophy? Update(int id, Trophy values)
        {
            var trophy = GetById(id);
            if (trophy != null)
            {
                trophy.Competition = values.Competition;
                trophy.Year = values.Year;
            }
            return trophy;
        }

    }
}
