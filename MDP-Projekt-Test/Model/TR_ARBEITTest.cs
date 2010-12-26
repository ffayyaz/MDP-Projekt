using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Objects.DataClasses;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for TR_ARBEITTest and is intended
    ///to contain all TR_ARBEITTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TR_ARBEITTest
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
        ///A test for TR_ARBEIT Constructor
        ///</summary>
        [TestMethod()]
        public void TR_ARBEITConstructorTest()
        {
            TR_ARBEIT target = new TR_ARBEIT();
            Assert.IsInstanceOfType(target, typeof(TR_ARBEIT));
        }

        /// <summary>
        ///A test for CreateTR_ARBEIT
        ///</summary>
        [TestMethod()]
        public void CreateTR_ARBEITTest()
        {
            int aRB_ID = 1;
            TR_ARBEIT rep = TR_ARBEIT.CreateTR_ARBEIT(aRB_ID);
            Assert.IsTrue(rep.ARB_ID== aRB_ID);
        }

        /// <summary>
        ///A test for ARB_BEZEICHNUNG
        ///</summary>
        [TestMethod()]
        public void ARB_BEZEICHNUNGTest()
        {
            TR_ARBEIT arb = new TR_ARBEIT();
            string expected = "arbeit";
            arb.ARB_BEZEICHNUNG= expected;
            Assert.AreEqual(expected, arb.ARB_BEZEICHNUNG);
        }

        /// <summary>
        ///A test for ARB_ID
        ///</summary>
        [TestMethod()]
        public void ARB_IDTest()
        {
            TR_ARBEIT arb = new TR_ARBEIT();
            int expected = 1;
            arb.ARB_ID = expected;
            Assert.AreEqual(expected, arb.ARB_ID);
        }

        /// <summary>
        ///A test for ARB_PREIS
        ///</summary>
        [TestMethod()]
        public void ARB_PREISTest()
        {
            TR_ARBEIT arb = new TR_ARBEIT();
            decimal expected = new Decimal(2.2);
            arb.ARB_PREIS = expected;
            Assert.AreEqual(expected, arb.ARB_PREIS);
        }

        /*
        /// <summary>
        ///A test for TZ_ARBEITLISTE
        ///</summary>
        [TestMethod()]
        public void TZ_ARBEITLISTETest()
        {
            TR_ARBEIT target = new TR_ARBEIT(); // TODO: Initialize to an appropriate value
            EntityCollection<TZ_ARBEITLISTE> expected = null; // TODO: Initialize to an appropriate value
            EntityCollection<TZ_ARBEITLISTE> actual;
            target.TZ_ARBEITLISTE = expected;
            actual = target.TZ_ARBEITLISTE;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
         */
    }
}
