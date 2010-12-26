using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Objects.DataClasses;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for TZ_FAHRZEUGTYPTest and is intended
    ///to contain all TZ_FAHRZEUGTYPTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TZ_FAHRZEUGTYPTest
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
        ///A test for TZ_FAHRZEUGTYP Constructor
        ///</summary>
        [TestMethod()]
        public void TZ_FAHRZEUGTYPConstructorTest()
        {
            TZ_FAHRZEUGTYP target = new TZ_FAHRZEUGTYP();
            Assert.IsInstanceOfType(target, typeof(TZ_FAHRZEUGTYP));
        }

        /// <summary>
        ///A test for CreateTZ_FAHRZEUGTYP
        ///</summary>
        [TestMethod()]
        public void CreateTZ_FAHRZEUGTYPTest()
        {
            int fZT_ID = 1;
            TZ_FAHRZEUGTYP fzgTyp = TZ_FAHRZEUGTYP.CreateTZ_FAHRZEUGTYP(fZT_ID);
            Assert.IsTrue(fzgTyp.FZT_ID == fZT_ID);
        }

        /// <summary>
        ///A test for FZT_BEZEICHNUNG
        ///</summary>
        [TestMethod()]
        public void FZT_BEZEICHNUNGTest()
        {
            TZ_FAHRZEUGTYP fzgTyp = new TZ_FAHRZEUGTYP();
            string expected = "Liberty";
            fzgTyp.FZT_BEZEICHNUNG = expected;
            Assert.AreEqual(expected, fzgTyp.FZT_BEZEICHNUNG);
        }

        /// <summary>
        ///A test for FZT_FZM_ID
        ///</summary>
        [TestMethod()]
        public void FZT_FZM_IDTest()
        {
            TZ_FAHRZEUGTYP fzgTyp = new TZ_FAHRZEUGTYP();
            int expected = 1;
            fzgTyp.FZT_FZM_ID = expected;
            Assert.AreEqual(expected, fzgTyp.FZT_FZM_ID);
        }

        /// <summary>
        ///A test for FZT_ID
        ///</summary>
        [TestMethod()]
        public void FZT_IDTest()
        {
            TZ_FAHRZEUGTYP fzgTyp = new TZ_FAHRZEUGTYP();
            int expected = 1;
            fzgTyp.FZT_ID = expected;
            Assert.AreEqual(expected, fzgTyp.FZT_ID);
        }

        /// <summary>
        ///A test for TR_FAHRZEUGMARKE
        ///</summary>
        [TestMethod()]
        public void TR_FAHRZEUGMARKETest()
        {
            TZ_FAHRZEUGTYP fzgTyp = new TZ_FAHRZEUGTYP();
            TR_FAHRZEUGMARKE expected = new TR_FAHRZEUGMARKE();
            expected.FZM_ID = 1;
            fzgTyp.TR_FAHRZEUGMARKE= expected;
            Assert.AreEqual(expected, fzgTyp.TR_FAHRZEUGMARKE);
        }

        /*
        /// <summary>
        ///A test for TR_FAHRZEUGMARKEReference
        ///</summary>
        [TestMethod()]
        public void TR_FAHRZEUGMARKEReferenceTest()
        {
            TZ_FAHRZEUGTYP target = new TZ_FAHRZEUGTYP(); // TODO: Initialize to an appropriate value
            EntityReference<TR_FAHRZEUGMARKE> expected = null; // TODO: Initialize to an appropriate value
            EntityReference<TR_FAHRZEUGMARKE> actual;
            target.TR_FAHRZEUGMARKEReference = expected;
            actual = target.TR_FAHRZEUGMARKEReference;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for T_FAHRZEUG
        ///</summary>
        [TestMethod()]
        public void T_FAHRZEUGTest()
        {
            TZ_FAHRZEUGTYP target = new TZ_FAHRZEUGTYP(); // TODO: Initialize to an appropriate value
            EntityCollection<T_FAHRZEUG> expected = null; // TODO: Initialize to an appropriate value
            EntityCollection<T_FAHRZEUG> actual;
            target.T_FAHRZEUG = expected;
            actual = target.T_FAHRZEUG;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for isNew
        ///</summary>
        [TestMethod()]
        public void isNewTest()
        {
            TZ_FAHRZEUGTYP target = new TZ_FAHRZEUGTYP(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.isNew;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
         */
    }
}
