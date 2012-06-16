using GestiuneBusiness.Enums;
using GestiuneBusiness.Poco;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
                IdFirma = 1,
                Numar = "Testing",
                Serie = "Testing"
            };
            var r = factura.Save();
            if (r.Status==StatusEnum.Errors)
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
                ID=1
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
    }
}
