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
        public void TestAddDipendente()
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
        public void TestGetDipendenti()
        {
            DipendenteDMController controller = new DipendenteDMController();
            List<ResponseGetDipendenti> listDip = controller.Get();

            Assert.GreaterOrEqual(idNewDip, listDip.Count);
        }

        [Test]
        public void TestGetDipendenteByID()
        {
            DipendenteDMController controller = new DipendenteDMController();
            Dipendente dip = controller.GetByID(1);

            Assert.AreEqual(dip.Cognome, "Bianchi");
            Assert.AreEqual(dip.Nome, "Marco");
        }

        [Test]
        public void TestDeleteDipendente()
        {
            DipendenteDMController controller = new DipendenteDMController();

            bool isDelete = controller.Delete(idNewDip);

            Assert.AreEqual(isDelete, true);
        }

        /// <summary>
        /// TEST CRUD CONVENZIONE
        /// </summary>

        [Test]
        public void TestAddConvenzione()
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
        public void TestGetConvenzioni()
        {
            ConvenzioneDMController controller = new ConvenzioneDMController();
            List<Convenzione> listCon = controller.Get();

            Assert.GreaterOrEqual(idNewConv, listCon.Count);
        }

        [Test]
        public void TestGetConvenzioneByID()
        {
            ConvenzioneDMController c = new ConvenzioneDMController();
            Convenzione dip = c.GetByID(1);

            Assert.AreEqual(dip.Titolo, "Sconto Auto");
        }

        [Test]
        public void TestDeleteConvenzione()
        {
            ConvenzioneDMController controller = new ConvenzioneDMController();

            bool isDelete = controller.Delete(idNewConv);

            Assert.AreEqual(isDelete, true);
        }
    }
}