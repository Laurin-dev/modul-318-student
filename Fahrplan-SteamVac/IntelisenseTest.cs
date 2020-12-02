using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fahrplan_SteamVac
{
    [TestClass]
    public class Fahrplan_SteamVacTest
    {
        [TestMethod]
        public void SuggestionsTest()
        {
            //given 
            Intelisense intelisenseTest = new Intelisense();
            string textToBeCompletetd = "Sur";
            List<string> expectedResult = new List<string> { "Sursee", "Romanel-sur-Lausanne", "Sur Roche", "Les Geneveys-sur-Coffrane", "Villars-sur-Ollon", "La Roche-sur-Foron", "Belmont-sur-Montreux", "Rabius-Surrein", "Sursee, Bahnhof", "Prélaz-sur-Blonay" };
            List<string> resultFromMethod = new List<string>();

            //when
            resultFromMethod = intelisenseTest.GetSuggestions(textToBeCompletetd);

            //then
            CollectionAssert.AreEqual(expectedResult, resultFromMethod);
        }
    }
}