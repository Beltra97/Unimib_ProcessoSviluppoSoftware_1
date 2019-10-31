using IntranetDAL.DMControllers;
using IntranetDAL.Models;
using IntranetDAL.Requests;
using IntranetDAL.Response;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class TestDB
    {
        [Test]
        public void UnitTestDescrizione()
        {
            Convenzione testc1 = new Convenzione();
            testc1.Titolo = "testTitolo";
            testc1.Descrizione = "testDescrizione";

            Assert.AreEqual(testc1.Titolo, "testTitolo");
            Assert.AreEqual(testc1.Descrizione, "testDescrizione");
        }

        [Test]
        public void UnitTestDipendente()
        {
            Dipendente testd1 = new Dipendente();
            testd1.Nome = "testNome";
            testd1.Cognome = "testCognome";

            Assert.AreEqual(testd1.Nome, "testNome");
            Assert.AreEqual(testd1.Cognome, "testCognome");
        }
    }
}