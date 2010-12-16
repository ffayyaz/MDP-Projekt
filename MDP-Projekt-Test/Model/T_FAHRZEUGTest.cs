using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for T_FAHRZEUGTest and is intended
    ///to contain all T_FAHRZEUGTest Unit Tests
    ///</summary>
    [TestClass()]
    public class T_FAHRZEUGTest
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
        ///A test for T_FAHRZEUG Constructor
        ///</summary>
        [TestMethod()]
        public void T_FAHRZEUGConstructorTest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CreateT_FAHRZEUG
        ///</summary>
        [TestMethod()]
        public void CreateT_FAHRZEUGTest()
        {
            int fZG_ID = 0; // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.T_FAHRZEUG expected = null; // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.T_FAHRZEUG actual;
            actual = MDP_Projekt.Model.T_FAHRZEUG.CreateT_FAHRZEUG(fZG_ID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZG_ERSTEINVERKEHR
        ///</summary>
        [TestMethod()]
        public void FZG_ERSTEINVERKEHRTest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            System.Nullable<System.DateTime> expected = new System.Nullable<System.DateTime>(); // TODO: Initialize to an appropriate value
            System.Nullable<System.DateTime> actual;
            target.FZG_ERSTEINVERKEHR = expected;
            actual = target.FZG_ERSTEINVERKEHR;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZG_FAHRZEUGNR
        ///</summary>
        [TestMethod()]
        public void FZG_FAHRZEUGNRTest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FZG_FAHRZEUGNR = expected;
            actual = target.FZG_FAHRZEUGNR;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZG_FZA_ID
        ///</summary>
        [TestMethod()]
        public void FZG_FZA_IDTest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            System.Nullable<int> expected = new System.Nullable<int>(); // TODO: Initialize to an appropriate value
            System.Nullable<int> actual;
            target.FZG_FZA_ID = expected;
            actual = target.FZG_FZA_ID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZG_FZM_ID
        ///</summary>
        [TestMethod()]
        public void FZG_FZM_IDTest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            System.Nullable<int> expected = new System.Nullable<int>(); // TODO: Initialize to an appropriate value
            System.Nullable<int> actual;
            target.FZG_FZM_ID = expected;
            actual = target.FZG_FZM_ID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZG_ID
        ///</summary>
        [TestMethod()]
        public void FZG_IDTest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.FZG_ID = expected;
            actual = target.FZG_ID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZG_NUT_ID
        ///</summary>
        [TestMethod()]
        public void FZG_NUT_IDTest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            System.Nullable<int> expected = new System.Nullable<int>(); // TODO: Initialize to an appropriate value
            System.Nullable<int> actual;
            target.FZG_NUT_ID = expected;
            actual = target.FZG_NUT_ID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZG_RAHMENNR
        ///</summary>
        [TestMethod()]
        public void FZG_RAHMENNRTest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FZG_RAHMENNR = expected;
            actual = target.FZG_RAHMENNR;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZG_SCHILDNR
        ///</summary>
        [TestMethod()]
        public void FZG_SCHILDNRTest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FZG_SCHILDNR = expected;
            actual = target.FZG_SCHILDNR;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZG_STAMMNR
        ///</summary>
        [TestMethod()]
        public void FZG_STAMMNRTest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FZG_STAMMNR = expected;
            actual = target.FZG_STAMMNR;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TR_FAHRZEUGART
        ///</summary>
        [TestMethod()]
        public void TR_FAHRZEUGARTTest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.TR_FAHRZEUGART expected = null; // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.TR_FAHRZEUGART actual;
            target.TR_FAHRZEUGART = expected;
            actual = target.TR_FAHRZEUGART;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TR_FAHRZEUGARTReference
        ///</summary>
        [TestMethod()]
        public void TR_FAHRZEUGARTReferenceTest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            System.Data.Objects.DataClasses.EntityReference<MDP_Projekt.Model.TR_FAHRZEUGART> expected = null; // TODO: Initialize to an appropriate value
            System.Data.Objects.DataClasses.EntityReference<MDP_Projekt.Model.TR_FAHRZEUGART> actual;
            target.TR_FAHRZEUGARTReference = expected;
            actual = target.TR_FAHRZEUGARTReference;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TZ_FAHRZEUGMARKE
        ///</summary>
        [TestMethod()]
        public void TZ_FAHRZEUGMARKETest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.TZ_FAHRZEUGMARKE expected = null; // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.TZ_FAHRZEUGMARKE actual;
            target.TZ_FAHRZEUGMARKE = expected;
            actual = target.TZ_FAHRZEUGMARKE;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TZ_FAHRZEUGMARKEReference
        ///</summary>
        [TestMethod()]
        public void TZ_FAHRZEUGMARKEReferenceTest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            System.Data.Objects.DataClasses.EntityReference<MDP_Projekt.Model.TZ_FAHRZEUGMARKE> expected = null; // TODO: Initialize to an appropriate value
            System.Data.Objects.DataClasses.EntityReference<MDP_Projekt.Model.TZ_FAHRZEUGMARKE> actual;
            target.TZ_FAHRZEUGMARKEReference = expected;
            actual = target.TZ_FAHRZEUGMARKEReference;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for T_NUTZER
        ///</summary>
        [TestMethod()]
        public void T_NUTZERTest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.T_NUTZER expected = null; // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.T_NUTZER actual;
            target.T_NUTZER = expected;
            actual = target.T_NUTZER;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for T_NUTZERReference
        ///</summary>
        [TestMethod()]
        public void T_NUTZERReferenceTest()
        {
            MDP_Projekt.Model.T_FAHRZEUG target = new MDP_Projekt.Model.T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            System.Data.Objects.DataClasses.EntityReference<MDP_Projekt.Model.T_NUTZER> expected = null; // TODO: Initialize to an appropriate value
            System.Data.Objects.DataClasses.EntityReference<MDP_Projekt.Model.T_NUTZER> actual;
            target.T_NUTZERReference = expected;
            actual = target.T_NUTZERReference;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
