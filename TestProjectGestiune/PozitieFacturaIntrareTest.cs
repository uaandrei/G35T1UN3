using GestiuneBusiness.Enums;
using GestiuneBusiness.Poco;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestiuneBusiness.DataHelper.Kernel;

namespace TestProjectGestiune
{


    /// <summary>
    ///This is a test class for PozitieFacturaIntrareTest and is intended
    ///to contain all PozitieFacturaIntrareTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PozitieFacturaIntrareTest
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
        public void InsertPozitieFacturaIntrareTest()
        {
            PozitieFacturaIntrare target = new PozitieFacturaIntrare
            {
                Cantitate = 130m,
                IdFacturaIntrare = 4,
                IdProdus = 1,
                PretUnitar = 15
            };
            if (target.Save().Status == StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void UpdatePozitieFacturaIntrareTest()
        {
            PozitieFacturaIntrare target = new PozitieFacturaIntrare
            {
                Cantitate = 10m,
                IdFacturaIntrare = 7,
                IdProdus = 1,
                PretUnitar = 15,
                ID = 1
            };
            if (target.Save().Status == StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void GetAllPozitieFacturaIntrareTest()
        {
            var list = PozitieFacturaIntrare.GetAll();
            if (list == null)
            {
                Assert.Fail();
            }
        }
    }
}
