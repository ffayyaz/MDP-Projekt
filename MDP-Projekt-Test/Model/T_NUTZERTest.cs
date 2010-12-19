using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Objects.DataClasses;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for T_NUTZERTest and is intended
    ///to contain all T_NUTZERTest Unit Tests
    ///</summary>
    [TestClass()]
    public class T_NUTZERTest
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
        ///A test for T_NUTZER Constructor
        ///</summary>
        [TestMethod()]
        public void T_NUTZERConstructorTest()
        {
            T_NUTZER nutzer = new T_NUTZER();
            Assert.IsInstanceOfType(nutzer, typeof(T_NUTZER));            
        }

        /// <summary>
        ///A test for CreateT_NUTZER
        ///</summary>
        [TestMethod()]
        public void CreateT_NUTZERTest()
        {
            int nUT_ID = 1; 
            string nUT_NAME = "Poststelle";
            T_NUTZER nutzer = T_NUTZER.CreateT_NUTZER(nUT_ID, nUT_NAME);
            Assert.IsTrue(nutzer.NUT_ID == nUT_ID && nutzer.NUT_NAME.Equals(nUT_NAME));
        }

        /// <summary>
        ///A test for NUT_ID
        ///</summary>
        [TestMethod()]
        public void NUT_IDTest()
        {
            T_NUTZER nutzer = new T_NUTZER(); 
            int expected = 1; 
            nutzer.NUT_ID = expected;
            Assert.AreEqual(expected, nutzer.NUT_ID);
        }

        /// <summary>
        ///A test for NUT_NAME
        ///</summary>
        [TestMethod()]
        public void NUT_NAMETest()
        {
            T_NUTZER nutzer = new T_NUTZER(); 
            string expected = "Poststelle"; 
            nutzer.NUT_NAME = expected;
            Assert.AreEqual(expected, nutzer.NUT_NAME);
        }

        /// <summary>
        ///A test for NUT_ORT
        ///</summary>
        [TestMethod()]
        public void NUT_ORTTest()
        {
            T_NUTZER nutzer = new T_NUTZER();
            string expected = "Cham"; 
            nutzer.NUT_ORT = expected;
            Assert.AreEqual(expected, nutzer.NUT_ORT);
        }

        /// <summary>
        ///A test for NUT_PLZ
        ///</summary>
        [TestMethod()]
        public void NUT_PLZTest()
        {
            T_NUTZER nutzer = new T_NUTZER(); 
            Nullable<int> expected = 6330; 
            nutzer.NUT_PLZ = expected;
            Assert.AreEqual(expected, nutzer.NUT_PLZ);
        }

        /// <summary>
        ///A test for T_FAHRZEUG
        ///</summary>
        [TestMethod()]
        public void T_FAHRZEUGTest()
        {
            T_NUTZER nutzer = new T_NUTZER(); // TODO: Initialize to an appropriate value
            EntityCollection<T_FAHRZEUG> expected = null; // TODO: Initialize to an appropriate value
            EntityCollection<T_FAHRZEUG> actual;
            nutzer.T_FAHRZEUG = expected;
            actual = nutzer.T_FAHRZEUG;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
