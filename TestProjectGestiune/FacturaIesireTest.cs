using System.Linq;
using GestiuneBusiness.Enums;
using GestiuneBusiness.Poco;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using GestiuneBusiness.DataHelper.Kernel;

namespace TestProjectGestiune
{


    /// <summary>
    ///This is a test class for FacturaIesireTest and is intended
    ///to contain all FacturaIesireTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FacturaIesireTest
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

        [TestMethod]
        public void InsertFacturaIesireTest()
        {
            var factura = new FacturaIesire
            {
                Data = DateTime.Now,
                IdFirma = 2,
                Numar = "Testing",
                Serie = "Testing"
            };
            var r = factura.Save();
            if (r.Status == StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void UpdateFacturaIesireTest()
        {
            var factura = new FacturaIesire
            {
                Data = DateTime.Now,
                IdFirma = 1,
                Numar = "Modificat",
                Serie = "Testing",
                ID = 1
            };
            var r = factura.Save();
            if (r.Status == StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetAllFacturaIesireTest()
        {
            var list = FacturaIesire.GetAll();
            if (list == null)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SalvareFacturaIesireCuPozitiiTest()
        {
            FacturaIesire target = new FacturaIesire
            {
                CotaTva = 19,
                Data = DateTime.Now,
                IdFirma = 2,
                Numar = "xxx",
                Serie = "xxx"
            };
            List<PozitieFacturaIesire> pozitiiList = new List<PozitieFacturaIesire>();
            var stoc = Stoc.GetAll().Where(p => p.ID == 27).First();
            stoc.Cantitate -= 100;
            pozitiiList.Add(new PozitieFacturaIesire
            {
                Cantitate = 100,
                IdStoc = 27,
                PretUnitar = 55,
            });
            var stoc1 = Stoc.GetAll().Where(p => p.ID == 26).First();
            stoc1.Cantitate -= 10;
            pozitiiList.Add(new PozitieFacturaIesire
            {
                Cantitate = 10,
                IdStoc = 26,
                PretUnitar = 55,
            });
            var stoc2 = Stoc.GetAll().Where(p => p.ID == 25).First();
            stoc2.Cantitate -= 10;
            pozitiiList.Add(new PozitieFacturaIesire
            {
                Cantitate = 10,
                IdStoc = 25,
                PretUnitar = 55,
            });

            PersistenceResult actual = target.Save(pozitiiList);
            if (actual.Status == StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }
    }
}
