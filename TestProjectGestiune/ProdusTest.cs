using GestiuneBusiness.Enums;
using GestiuneBusiness.Poco;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestiuneBusiness.DataHelper.Kernel;

namespace TestProjectGestiune
{


    /// <summary>
    ///This is a test class for ProdusTest and is intended
    ///to contain all ProdusTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProdusTest
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
        public void InsertProdusTest()
        {
            var target = new Produs
            {
                Nume = "Testing1",
                Pret = 123m,
                RataTva = 0.12m,
                StocMinim = 12,
                Um = "Testing"
            };
            if (target.Save().Status != StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void UpdateProdusTest()
        {
            var target = new Produs
            {
                Nume = "Modificat",
                Pret = 123m,
                RataTva = 0.12m,
                StocMinim = 122,
                Um = "Modificat",
                ID=1
            };
            if (target.Save().Status == StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void GetAllProdusTest()
        {
            var list=Produs.GetAll();
            if (list == null)
            {
                Assert.Fail();
            }
        }
    }
}
