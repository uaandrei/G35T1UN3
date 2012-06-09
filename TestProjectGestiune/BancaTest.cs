using GestiuneBusiness.DataHelper;
using GestiuneBusiness.Poco;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestiuneBusiness.DataHelper.Kernel;
using System.Collections.Generic;

namespace TestProjectGestiune
{
    
    
    /// <summary>
    ///This is a test class for BancaTest and is intended
    ///to contain all BancaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BancaTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void BancaSaveTest()
        {
            Banca target = new Banca
            {
                Nume="BCR",
                Adresa="Bucuresti",
                CodIdentificareFiscala="123/ffa",
                NrOrc="123OP"
            };
            PersistenceResult expected = new PersistenceResult {Status=GestiuneBusiness.Enums.EnumStatus.Errors };
            PersistenceResult actual;
            actual = target.Save();
            Assert.AreEqual(expected.Status, actual.Status);
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void BancaGetAllTest()
        {
            List<Banca> actual;
            actual = Banca.GetAll();
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void BancaGetByIdTest()
        {
            Banca expected = new Banca
            {
                ID=1,
                Nume = "BCR",
                Adresa = "Bucuresti",
                CodIdentificareFiscala = "123/ffa",
                NrOrc = "123OP"
            };
            Banca actual = (Banca)BanciDataHelper_Accessor.GetInstance().GetById(1);
            Assert.IsTrue(expected.ID == actual.ID);
            Assert.IsTrue(expected.Nume == actual.Nume);
            Assert.IsTrue(expected.Adresa == actual.Adresa);
            Assert.IsTrue(expected.CodIdentificareFiscala == actual.CodIdentificareFiscala);
            Assert.IsTrue(expected.NrOrc == actual.NrOrc);
        }
    }
}
