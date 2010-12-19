using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Objects.DataClasses;

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
            T_FAHRZEUG fzg = new T_FAHRZEUG();
            Assert.IsInstanceOfType(fzg, typeof(T_FAHRZEUG));
        }

        /// <summary>
        ///A test for CreateT_FAHRZEUG
        ///</summary>
        [TestMethod()]
        public void CreateT_FAHRZEUGTest()
        {
            int fZG_ID = 1;             
            T_FAHRZEUG fzg = T_FAHRZEUG.CreateT_FAHRZEUG(fZG_ID);
            Assert.AreEqual(fzg.FZG_ID, fZG_ID);
        }

        /// <summary>
        ///A test for FZG_ERSTEINVERKEHR
        ///</summary>
        [TestMethod()]
        public void FZG_ERSTEINVERKEHRTest()
        {
            T_FAHRZEUG fzg = new T_FAHRZEUG(); 
            Nullable<DateTime> expected = new Nullable<DateTime>();
            fzg.FZG_ERSTEINVERKEHR = expected;            
            Assert.AreEqual(expected, fzg.FZG_ERSTEINVERKEHR);
        }

        /// <summary>
        ///A test for FZG_FAHRZEUGNR
        ///</summary>
        [TestMethod()]
        public void FZG_FAHRZEUGNRTest()
        {            
            T_FAHRZEUG fzg = new T_FAHRZEUG(); 
            string expected = "999-666009"; 
            fzg.FZG_FAHRZEUGNR = expected;
            Assert.AreEqual(expected, fzg.FZG_FAHRZEUGNR);
        }

        /// <summary>
        ///A test for FZG_FZA_ID
        ///</summary>
        [TestMethod()]
        public void FZG_FZA_IDTest()
        {
            T_FAHRZEUG fzg = new T_FAHRZEUG(); 
            Nullable<int> expected = 1;
            fzg.FZG_FZA_ID = expected;
            Assert.AreEqual(expected, fzg.FZG_FZA_ID);
        }

        /// <summary>
        ///A test for FZG_FZM_ID
        ///</summary>
        [TestMethod()]
        public void FZG_FZM_IDTest()
        {
            T_FAHRZEUG fzg = new T_FAHRZEUG();
            Nullable<int> expected = 1; 
            fzg.FZG_FZM_ID = expected;
            Assert.AreEqual(expected, fzg.FZG_FZM_ID);
        }

        /// <summary>
        ///A test for FZG_ID
        ///</summary>
        [TestMethod()]
        public void FZG_IDTest()
        {
            T_FAHRZEUG fzg = new T_FAHRZEUG(); 
            int expected = 1; 
            fzg.FZG_ID = expected;
            Assert.AreEqual(expected, fzg.FZG_ID);
        }

        /// <summary>
        ///A test for FZG_NUT_ID
        ///</summary>
        [TestMethod()]
        public void FZG_NUT_IDTest()
        {
            T_FAHRZEUG fzg = new T_FAHRZEUG(); 
            Nullable<int> expected = 1; 
            fzg.FZG_NUT_ID = expected;
            Assert.AreEqual(expected, fzg.FZG_NUT_ID);
        }

        /// <summary>
        ///A test for FZG_RAHMENNR
        ///</summary>
        [TestMethod()]
        public void FZG_RAHMENNRTest()
        {
            T_FAHRZEUG fzg = new T_FAHRZEUG();
            string expected = "XC22AB49S##SD#SD"; 
            fzg.FZG_RAHMENNR = expected;
            Assert.AreEqual(expected, fzg.FZG_RAHMENNR);
        }

        /// <summary>
        ///A test for FZG_SCHILDNR
        ///</summary>
        [TestMethod()]
        public void FZG_SCHILDNRTest()
        {
            T_FAHRZEUG fzg = new T_FAHRZEUG(); 
            string expected = "BE 020-22"; 
            fzg.FZG_SCHILDNR = expected;
            Assert.AreEqual(expected, fzg.FZG_SCHILDNR);
        }

        /// <summary>
        ///A test for FZG_STAMMNR
        ///</summary>
        [TestMethod()]
        public void FZG_STAMMNRTest()
        {
            T_FAHRZEUG fzg = new T_FAHRZEUG(); 
            string expected = "2d22"; 
            fzg.FZG_STAMMNR = expected;
            Assert.AreEqual(expected, fzg.FZG_STAMMNR);
        }

        /// <summary>
        ///A test for TR_FAHRZEUGART
        ///</summary>
        [TestMethod()]
        public void TR_FAHRZEUGARTTest()
        {
            T_FAHRZEUG fzg = new T_FAHRZEUG();
            TR_FAHRZEUGART expected = new TR_FAHRZEUGART();
            expected.FZA_ID = 1;
            fzg.TR_FAHRZEUGART = expected;
            Assert.AreEqual(expected, fzg.TR_FAHRZEUGART);
        }

        /// <summary>
        ///A test for TR_FAHRZEUGARTReference
        ///</summary>
        [TestMethod()]
        public void TR_FAHRZEUGARTReferenceTest()
        {
            T_FAHRZEUG fzg = new T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            EntityReference<TR_FAHRZEUGART> expected = null; // TODO: Initialize to an appropriate value
            EntityReference<TR_FAHRZEUGART> actual;
            fzg.TR_FAHRZEUGARTReference = expected;
            actual = fzg.TR_FAHRZEUGARTReference;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TZ_FAHRZEUGMARKE
        ///</summary>
        [TestMethod()]
        public void TZ_FAHRZEUGMARKETest()
        {
            T_FAHRZEUG fzg = new T_FAHRZEUG(); 
            TZ_FAHRZEUGMARKE expected = new TZ_FAHRZEUGMARKE();
            expected.FZM_BEZEICHNUNG = "Vespa";
            fzg.TZ_FAHRZEUGMARKE = expected;
            Assert.AreEqual(expected, fzg.TZ_FAHRZEUGMARKE);
        }

        /// <summary>
        ///A test for TZ_FAHRZEUGMARKEReference
        ///</summary>
        [TestMethod()]
        public void TZ_FAHRZEUGMARKEReferenceTest()
        {
            T_FAHRZEUG fzg = new T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            EntityReference<TZ_FAHRZEUGMARKE> expected = null; // TODO: Initialize to an appropriate value
            EntityReference<TZ_FAHRZEUGMARKE> actual;
            fzg.TZ_FAHRZEUGMARKEReference = expected;
            actual = fzg.TZ_FAHRZEUGMARKEReference;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for T_NUTZER
        ///</summary>
        [TestMethod()]
        public void T_NUTZERTest()
        {
            T_FAHRZEUG fzg = new T_FAHRZEUG(); 
            T_NUTZER expected = new T_NUTZER();
            expected.NUT_ID = 1;
            fzg.T_NUTZER = expected;
            Assert.AreEqual(expected, fzg.T_NUTZER);
        }

        /// <summary>
        ///A test for T_NUTZERReference
        ///</summary>
        [TestMethod()]
        public void T_NUTZERReferenceTest()
        {
            T_FAHRZEUG fzg = new T_FAHRZEUG(); // TODO: Initialize to an appropriate value
            EntityReference<T_NUTZER> expected = null; // TODO: Initialize to an appropriate value
            EntityReference<T_NUTZER> actual;
            fzg.T_NUTZERReference = expected;
            actual = fzg.T_NUTZERReference;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
