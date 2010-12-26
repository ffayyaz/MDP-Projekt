using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Objects.DataClasses;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for T_REPARATURTest and is intended
    ///to contain all T_REPARATURTest Unit Tests
    ///</summary>
    [TestClass()]
    public class T_REPARATURTest
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
        ///A test for T_REPARATUR Constructor
        ///</summary>
        [TestMethod()]
        public void T_REPARATURConstructorTest()
        {
            T_REPARATUR target = new T_REPARATUR();
            Assert.IsInstanceOfType(target, typeof(T_REPARATUR));
        }

        /// <summary>
        ///A test for CreateT_REPARATUR
        ///</summary>
        [TestMethod()]
        public void CreateT_REPARATURTest()
        {
            int rEP_ID = 1;
            T_REPARATUR rep = T_REPARATUR.CreateT_REPARATUR(rEP_ID);
            Assert.IsTrue(rep.REP_ID == rEP_ID);
        }

        /// <summary>
        ///A test for REP_ABL_ID
        ///</summary>
        [TestMethod()]
        public void REP_ABL_IDTest()
        {
            T_REPARATUR rep = new T_REPARATUR();
            Nullable<int> expected = 1;
            rep.REP_ABL_ID = expected;
            Assert.AreEqual(expected, rep.REP_ABL_ID);
        }

        /// <summary>
        ///A test for REP_AUSGANG
        ///</summary>
        [TestMethod()]
        public void REP_AUSGANGTest()
        {
            T_REPARATUR rep = new T_REPARATUR();
            DateTime expected = new DateTime();
            rep.REP_AUSGANG = expected;
            Assert.AreEqual(expected, rep.REP_AUSGANG);
        }

        /// <summary>
        ///A test for REP_DISPONR
        ///</summary>
        [TestMethod()]
        public void REP_DISPONRTest()
        {
            T_REPARATUR rep = new T_REPARATUR();
            string expected = "22";
            rep.REP_DISPONR = expected;
            Assert.AreEqual(expected, rep.REP_DISPONR);
        }

        /// <summary>
        ///A test for REP_EINGANG
        ///</summary>
        [TestMethod()]
        public void REP_EINGANGTest()
        {
            T_REPARATUR rep = new T_REPARATUR();
            DateTime expected = new DateTime();
            rep.REP_EINGANG = expected;
            Assert.AreEqual(expected, rep.REP_EINGANG);
        }

        /// <summary>
        ///A test for REP_FAHRZEUGKM
        ///</summary>
        [TestMethod()]
        public void REP_FAHRZEUGKMTest()
        {
            T_REPARATUR rep = new T_REPARATUR();
            int expected = 1;
            rep.REP_FAHRZEUGKM = expected;
            Assert.AreEqual(expected, rep.REP_FAHRZEUGKM);
        }

        /// <summary>
        ///A test for REP_FZG_ID
        ///</summary>
        [TestMethod()]
        public void REP_FZG_IDTest()
        {
            T_REPARATUR rep = new T_REPARATUR();
            int expected = 1;
            rep.REP_FZG_ID = expected;
            Assert.AreEqual(expected, rep.REP_FZG_ID);
        }

        /// <summary>
        ///A test for REP_ID
        ///</summary>
        [TestMethod()]
        public void REP_IDTest()
        {
            T_REPARATUR rep = new T_REPARATUR();
            int expected = 1;
            rep.REP_ID = expected;
            Assert.AreEqual(expected, rep.REP_ID);
        }

        /// <summary>
        ///A test for REP_MTL_ID
        ///</summary>
        [TestMethod()]
        public void REP_MTL_IDTest()
        {
            T_REPARATUR rep = new T_REPARATUR();
            int expected = 1;
            rep.REP_MTL_ID = expected;
            Assert.AreEqual(expected, rep.REP_MTL_ID);
        }

        /// <summary>
        ///A test for REP_RECHNUNGSNR
        ///</summary>
        [TestMethod()]
        public void REP_RECHNUNGSNRTest()
        {
            T_REPARATUR rep = new T_REPARATUR();
            int expected = 1;
            rep.REP_RECHNUNGSNR = expected;
            Assert.AreEqual(expected, rep.REP_RECHNUNGSNR);
        }

        /// <summary>
        ///A test for TZ_ARBEITLISTE
        ///</summary>
        [TestMethod()]
        public void TZ_ARBEITLISTETest()
        {
            T_REPARATUR rep = new T_REPARATUR();
            TZ_ARBEITLISTE expected = new TZ_ARBEITLISTE();
            expected.ABL_ID = 1;
            rep.TZ_ARBEITLISTE= expected;
            Assert.AreEqual(expected, rep.TZ_ARBEITLISTE);
        }

        /*
        /// <summary>
        ///A test for TZ_ARBEITLISTEReference
        ///</summary>
        [TestMethod()]
        public void TZ_ARBEITLISTEReferenceTest()
        {
            T_REPARATUR target = new T_REPARATUR(); // TODO: Initialize to an appropriate value
            EntityReference<TZ_ARBEITLISTE> expected = null; // TODO: Initialize to an appropriate value
            EntityReference<TZ_ARBEITLISTE> actual;
            target.TZ_ARBEITLISTEReference = expected;
            actual = target.TZ_ARBEITLISTEReference;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
         */

        /// <summary>
        ///A test for TZ_MATERIALLISTE
        ///</summary>
        [TestMethod()]
        public void TZ_MATERIALLISTETest()
        {           
            T_REPARATUR rep = new T_REPARATUR();
            TZ_MATERIALLISTE expected = new TZ_MATERIALLISTE();
            expected.MTL_ID = 1;
            rep.TZ_MATERIALLISTE= expected;
            Assert.AreEqual(expected, rep.TZ_MATERIALLISTE);
        }

        /*
        /// <summary>
        ///A test for TZ_MATERIALLISTEReference
        ///</summary>
        [TestMethod()]
        public void TZ_MATERIALLISTEReferenceTest()
        {
            T_REPARATUR target = new T_REPARATUR(); // TODO: Initialize to an appropriate value
            EntityReference<TZ_MATERIALLISTE> expected = null; // TODO: Initialize to an appropriate value
            EntityReference<TZ_MATERIALLISTE> actual;
            target.TZ_MATERIALLISTEReference = expected;
            actual = target.TZ_MATERIALLISTEReference;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
         */

        /// <summary>
        ///A test for T_FAHRZEUG
        ///</summary>
        [TestMethod()]
        public void T_FAHRZEUGTest()
        {          
            T_REPARATUR rep = new T_REPARATUR();
            T_FAHRZEUG expected = new T_FAHRZEUG();
            expected.FZG_ID = 1;
            rep.T_FAHRZEUG= expected;
            Assert.AreEqual(expected, rep.T_FAHRZEUG);
        }


        /*
        /// <summary>
        ///A test for T_FAHRZEUGReference
        ///</summary>
        [TestMethod()]
        public void T_FAHRZEUGReferenceTest()
        {
            T_REPARATUR target = new T_REPARATUR(); // TODO: Initialize to an appropriate value
            EntityReference<T_FAHRZEUG> expected = null; // TODO: Initialize to an appropriate value
            EntityReference<T_FAHRZEUG> actual;
            target.T_FAHRZEUGReference = expected;
            actual = target.T_FAHRZEUGReference;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
         */
    }
}
