using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for TZ_FAHRZEUGMARKETest and is intended
    ///to contain all TZ_FAHRZEUGMARKETest Unit Tests
    ///</summary>
    [TestClass()]
    public class TZ_FAHRZEUGMARKETest
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
        ///A test for TZ_FAHRZEUGMARKE Constructor
        ///</summary>
        [TestMethod()]
        public void TZ_FAHRZEUGMARKEConstructorTest()
        {
            MDP_Projekt.Model.TZ_FAHRZEUGMARKE target = new MDP_Projekt.Model.TZ_FAHRZEUGMARKE();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CreateTZ_FAHRZEUGMARKE
        ///</summary>
        [TestMethod()]
        public void CreateTZ_FAHRZEUGMARKETest()
        {
            int fZM_ID = 0; // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.TZ_FAHRZEUGMARKE expected = null; // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.TZ_FAHRZEUGMARKE actual;
            actual = MDP_Projekt.Model.TZ_FAHRZEUGMARKE.CreateTZ_FAHRZEUGMARKE(fZM_ID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZM_BEZEICHNUNG
        ///</summary>
        [TestMethod()]
        public void FZM_BEZEICHNUNGTest()
        {
            MDP_Projekt.Model.TZ_FAHRZEUGMARKE target = new MDP_Projekt.Model.TZ_FAHRZEUGMARKE(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FZM_BEZEICHNUNG = expected;
            actual = target.FZM_BEZEICHNUNG;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZM_FZT_ID
        ///</summary>
        [TestMethod()]
        public void FZM_FZT_IDTest()
        {
            MDP_Projekt.Model.TZ_FAHRZEUGMARKE target = new MDP_Projekt.Model.TZ_FAHRZEUGMARKE(); // TODO: Initialize to an appropriate value
            System.Nullable<int> expected = new System.Nullable<int>(); // TODO: Initialize to an appropriate value
            System.Nullable<int> actual;
            target.FZM_FZT_ID = expected;
            actual = target.FZM_FZT_ID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZM_ID
        ///</summary>
        [TestMethod()]
        public void FZM_IDTest()
        {
            MDP_Projekt.Model.TZ_FAHRZEUGMARKE target = new MDP_Projekt.Model.TZ_FAHRZEUGMARKE(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.FZM_ID = expected;
            actual = target.FZM_ID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TR_FAHRZEUGTYP
        ///</summary>
        [TestMethod()]
        public void TR_FAHRZEUGTYPTest()
        {
            MDP_Projekt.Model.TZ_FAHRZEUGMARKE target = new MDP_Projekt.Model.TZ_FAHRZEUGMARKE(); // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.TR_FAHRZEUGTYP expected = null; // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.TR_FAHRZEUGTYP actual;
            target.TR_FAHRZEUGTYP = expected;
            actual = target.TR_FAHRZEUGTYP;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TR_FAHRZEUGTYPReference
        ///</summary>
        [TestMethod()]
        public void TR_FAHRZEUGTYPReferenceTest()
        {
            MDP_Projekt.Model.TZ_FAHRZEUGMARKE target = new MDP_Projekt.Model.TZ_FAHRZEUGMARKE(); // TODO: Initialize to an appropriate value
            System.Data.Objects.DataClasses.EntityReference<MDP_Projekt.Model.TR_FAHRZEUGTYP> expected = null; // TODO: Initialize to an appropriate value
            System.Data.Objects.DataClasses.EntityReference<MDP_Projekt.Model.TR_FAHRZEUGTYP> actual;
            target.TR_FAHRZEUGTYPReference = expected;
            actual = target.TR_FAHRZEUGTYPReference;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for T_FAHRZEUG
        ///</summary>
        [TestMethod()]
        public void T_FAHRZEUGTest()
        {
            MDP_Projekt.Model.TZ_FAHRZEUGMARKE target = new MDP_Projekt.Model.TZ_FAHRZEUGMARKE(); // TODO: Initialize to an appropriate value
            System.Data.Objects.DataClasses.EntityCollection<MDP_Projekt.Model.T_FAHRZEUG> expected = null; // TODO: Initialize to an appropriate value
            System.Data.Objects.DataClasses.EntityCollection<MDP_Projekt.Model.T_FAHRZEUG> actual;
            target.T_FAHRZEUG = expected;
            actual = target.T_FAHRZEUG;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
