using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Objects.DataClasses;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for TZ_ARBEITLISTETest and is intended
    ///to contain all TZ_ARBEITLISTETest Unit Tests
    ///</summary>
    [TestClass()]
    public class TZ_ARBEITLISTETest
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
        ///A test for TZ_ARBEITLISTE Constructor
        ///</summary>
        [TestMethod()]
        public void TZ_ARBEITLISTEConstructorTest()
        {
            TZ_ARBEITLISTE target = new TZ_ARBEITLISTE();
            Assert.IsInstanceOfType(target, typeof(TZ_ARBEITLISTE));
        }

        /// <summary>
        ///A test for CreateTZ_ARBEITLISTE
        ///</summary>
        [TestMethod()]
        public void CreateTZ_ARBEITLISTETest()
        {
            int aBL_ID = 1;
            TZ_ARBEITLISTE al = TZ_ARBEITLISTE.CreateTZ_ARBEITLISTE(aBL_ID);
            Assert.IsTrue(al.ABL_ID == aBL_ID);
        }

        /// <summary>
        ///A test for ABL_ARB_ID
        ///</summary>
        [TestMethod()]
        public void ABL_ARB_IDTest()
        {
            TZ_ARBEITLISTE al = new TZ_ARBEITLISTE();
            int expected = 1;
            al.ABL_ARB_ID= expected;
            Assert.AreEqual(expected, al.ABL_ARB_ID);
        }

        /// <summary>
        ///A test for ABL_ID
        ///</summary>
        [TestMethod()]
        public void ABL_IDTest()
        {
            TZ_ARBEITLISTE al = new TZ_ARBEITLISTE();
            int expected = 1;
            al.ABL_ID= expected;
            Assert.AreEqual(expected, al.ABL_ID);
        }

        /// <summary>
        ///A test for ABL_MENGE
        ///</summary>
        [TestMethod()]
        public void ABL_MENGETest()
        {
            TZ_ARBEITLISTE al = new TZ_ARBEITLISTE();
            decimal expected = new Decimal(2.0);
            al.ABL_MENGE = expected;
            Assert.AreEqual(expected, al.ABL_MENGE);
        }

        /// <summary>
        ///A test for TR_ARBEIT
        ///</summary>
        [TestMethod()]
        public void TR_ARBEITTest()
        {
            TZ_ARBEITLISTE al = new TZ_ARBEITLISTE();
            TR_ARBEIT expected = new TR_ARBEIT();
            expected.ARB_ID = 1;
            al.TR_ARBEIT= expected;
            Assert.AreEqual(expected, al.TR_ARBEIT);
        }

        /*
        /// <summary>
        ///A test for TR_ARBEITReference
        ///</summary>
        [TestMethod()]
        public void TR_ARBEITReferenceTest()
        {
            TZ_ARBEITLISTE target = new TZ_ARBEITLISTE(); // TODO: Initialize to an appropriate value
            EntityReference<TR_ARBEIT> expected = null; // TODO: Initialize to an appropriate value
            EntityReference<TR_ARBEIT> actual;
            target.TR_ARBEITReference = expected;
            actual = target.TR_ARBEITReference;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
        

        /// <summary>
        ///A test for T_REPARATUR
        ///</summary>
        [TestMethod()]
        public void T_REPARATURTest()
        {
            TZ_ARBEITLISTE target = new TZ_ARBEITLISTE(); // TODO: Initialize to an appropriate value
            EntityCollection<T_REPARATUR> expected = null; // TODO: Initialize to an appropriate value
            EntityCollection<T_REPARATUR> actual;
            target.T_REPARATUR = expected;
            actual = target.T_REPARATUR;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
         */
    }
}
