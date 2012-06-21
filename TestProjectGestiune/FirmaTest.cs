using GestiuneBusiness.Enums;
using GestiuneBusiness.Poco;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestiuneBusiness.DataHelper.Kernel;

namespace TestProjectGestiune
{


    /// <summary>
    ///This is a test class for FirmaTest and is intended
    ///to contain all FirmaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FirmaTest
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
        public void ContainsTextFirmaTest()
        {
            var firma = new Firma
            {
                Adresa = "abc",
                Cui = "cde",
                DataInfiintarii = DateTime.Now,
                Iban = "xyz",
                IdBanca = 2,
                IdDelegat = 2,
                Nume = "poi",
                Rc = "pay",
                Telefon = "y+2223"
            };
            string text = "21 2012";
            var actual = firma.Contains(text);
            var expected = true;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void InsertFirmaTest()
        {
            var firma = new Firma
            {
                Adresa = "Testing",
                Cui = "Testing",
                DataInfiintarii = DateTime.Now,
                Iban = "Testing",
                IdBanca = 1,
                IdDelegat = 1,
                Nume = "Testing",
                Rc = "Testing",
                Telefon = "Testing"
            };
            var r = firma.Save();
            if (r.Status != StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void UpdateFirmaTest()
        {
            var firma = new Firma
            {
                Adresa = "Modificat",
                Cui = "Modificat2",
                DataInfiintarii = DateTime.Now,
                Iban = "Modificat",
                IdBanca = 1,
                IdDelegat = 1,
                Nume = "Testing",
                Rc = "Modificat",
                Telefon = "Modificat",
                ID = 3
            };
            var r = firma.Save();
            if (r.Status == StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }


    }
}
