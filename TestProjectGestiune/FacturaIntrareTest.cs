using GestiuneBusiness.Enums;
using GestiuneBusiness.Poco;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestiuneBusiness.DataHelper.Kernel;
using System.Collections.Generic;

namespace TestProjectGestiune
{


    /// <summary>
    ///This is a test class for FacturaIntrareTest and is intended
    ///to contain all FacturaIntrareTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FacturaIntrareTest
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
        public void InsertFacturaIntrareTest()
        {
            var target = new FacturaIntrare
            {
                Data = DateTime.Now,
                IdFirma = 2,
                Numar = "Testing",
                Serie = "Testing"
            };
            var r = target.Save();
            if (r.Status == StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void UpdateFacturaIntrareTest()
        {
            var target = new FacturaIntrare
            {
                Data = DateTime.Now,
                IdFirma = 1,
                Numar = "Testing",
                Serie = "TestingModificatIntrare",
                ID = 1
            };
            var r = target.Save();
            if (r.Status == StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void GetAllFacturaIntrareTest()
        {
            var target = FacturaIntrare.GetAll();
            if (target == null)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SalvareFacturaIntrareCuPozitii()
        {
            FacturaIntrare target = new FacturaIntrare
            {
                CotaTva = 19.00m,
                IdFirma = 2,
                Numar = "bla bla",
                Serie = "bla bla 2",
                Data=DateTime.Now
            };
            List<PozitieFacturaIntrare> pozitieFacturaIntrareList = new List<PozitieFacturaIntrare>();
            pozitieFacturaIntrareList.Add(new PozitieFacturaIntrare
            {
                Cantitate = 10,
                IdProdus = 1,
                PretUnitar = 123
            });
            pozitieFacturaIntrareList.Add(new PozitieFacturaIntrare
            {
                Cantitate = 110,
                IdProdus = 2,
                PretUnitar = 1223
            });
            pozitieFacturaIntrareList.Add(new PozitieFacturaIntrare
            {
                Cantitate = 105,
                IdProdus = 17,
                PretUnitar = 1236
            });
            pozitieFacturaIntrareList.Add(new PozitieFacturaIntrare
            {
                Cantitate = 160,
                IdProdus = 1,
                PretUnitar = 1623
            });
            PersistenceResult actual;
            actual = target.Save(pozitieFacturaIntrareList);
            if (actual.Status == StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }
    }
}
