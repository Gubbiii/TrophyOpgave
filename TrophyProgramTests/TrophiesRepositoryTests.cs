using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrophyProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrophyProgram.Tests
{
    [TestClass()]
    public class TrophiesRepositoryTests
    {
        [TestMethod()]
        public void TrophiesRepositoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Trophy trophy = new Trophy();
            trophy.Year = 2020;
            trophy.ID = 1;
            trophy.Competition = "Svømning";
            List<Trophy> trophiesTest = new List<Trophy> { trophy };
            TrophiesRepository repository = new TrophiesRepository();

            Trophy? result = repository.GetById(trophy.ID);

            Assert.AreEqual(trophy, result);
        }

        [TestMethod()]
        public void AddTest()
        {
            TrophiesRepository repository = new TrophiesRepository();
            Trophy newTrophy = new Trophy { Competition = "Tennis", Year = 2022 };

            Trophy addedTrophy = repository.Add(newTrophy);
            List<Trophy> allTrophies = repository.Get();

            Assert.IsNotNull(addedTrophy);
            Assert.AreEqual(0, addedTrophy.ID); // ID starter fra 0
            Assert.AreEqual(1, allTrophies.Count); // Skal være gemt
            Assert.AreEqual("Tennis", allTrophies[0].Competition);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}