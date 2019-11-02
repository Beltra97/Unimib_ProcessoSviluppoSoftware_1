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
        int idNewDip = 0;
        int idNewConv = 0;

        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// TEST CRUD DIPENDENTE
        /// </summary>


        [Test]
        public void Test1AddDipendente()
        {
            DipendenteDMController controller = new DipendenteDMController();

            RequestAddDipendente d = new RequestAddDipendente()
            {
                Cognome = "Verdi",
                Nome = "Carlo",
                Username = "carlo.verdi",
                Psw = "1234",
                IDRuolo = 3
            };

            idNewDip = controller.Add(d);

            Assert.Greater(idNewDip, 0);
        }

        [Test]
        public void Test2GetDipendenti()
        {
            DipendenteDMController controller = new DipendenteDMController();
            List<ResponseGetDipendenti> listDip = controller.Get();

            Assert.GreaterOrEqual(idNewDip, listDip.Count);
        }

        [Test]
        public void Test3GetDipendenteByID()
        {
            DipendenteDMController controller = new DipendenteDMController();
            Dipendente dip = controller.GetByID(1);

            Assert.AreEqual(dip.Cognome, "Bianchi");
            Assert.AreEqual(dip.Nome, "Marco");
        }

        [Test]
        public void Test4UpdateDipendente()
        {
            DipendenteDMController controller = new DipendenteDMController();

            RequestAddDipendente d = new RequestAddDipendente()
            {
                Cognome = "Verdi",
                Nome = "Carlo",
                Username = "carlo.verdi",
            };
            controller.Update(idNewDip, d);

            Dipendente dip = controller.GetByID(idNewDip);

            Assert.AreEqual(dip.Cognome, "Verdi");
            Assert.AreEqual(dip.Nome, "Carlo");
            Assert.AreEqual(dip.Username, "carlo.verdi");
        }

        [Test]
        public void Test5DeleteDipendente()
        {
            DipendenteDMController controller = new DipendenteDMController();

            bool isDelete = controller.Delete(idNewDip);

            Assert.AreEqual(isDelete, true);
        }

        /// <summary>
        /// TEST CRUD CONVENZIONE
        /// </summary>

        [Test]
        public void Test1AddConvenzione()
        {
            ConvenzioneDMController controller = new ConvenzioneDMController();

            RequestAddConvenzione d = new RequestAddConvenzione()
            {
                Titolo = "Sconto parcheggio",
                Descrizione = "Lorem ipsum"
            };

            idNewConv = controller.Add(d);

            Assert.Greater(idNewConv, 0);
        }

        [Test]
        public void Test2GetConvenzioni()
        {
            ConvenzioneDMController controller = new ConvenzioneDMController();
            List<Convenzione> listCon = controller.Get();

            Assert.GreaterOrEqual(idNewConv, listCon.Count);
        }

        [Test]
        public void Test3GetConvenzioneByID()
        {
            ConvenzioneDMController c = new ConvenzioneDMController();
            Convenzione dip = c.GetByID(1);

            Assert.AreEqual(dip.Titolo, "Sconto Auto");
        }

        [Test]
        public void Test4UpdateConvenzione()
        {
            ConvenzioneDMController controller = new ConvenzioneDMController();

            RequestAddConvenzione d = new RequestAddConvenzione()
            {
                Titolo = "Sconto carburante",
                Descrizione = "Lorem ipsum2"
            };
            controller.Update(idNewConv, d);

            Convenzione conv = controller.GetByID(idNewConv);

            Assert.AreEqual(conv.Titolo, "Sconto carburante");
            Assert.AreEqual(conv.Descrizione, "Lorem ipsum2");
        }

        [Test]
        public void Test5DeleteConvenzione()
        {
            ConvenzioneDMController controller = new ConvenzioneDMController();

            bool isDelete = controller.Delete(idNewConv);

            Assert.AreEqual(isDelete, true);
        }
    }
}