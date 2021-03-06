﻿using MDP_Projekt.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for NutzerDatenUITest and is intended
    ///to contain all NutzerDatenUITest Unit Tests
    ///</summary>
    [TestClass()]
    public class NutzerDatenUITest
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


        /*
        /// <summary>
        ///A test for NutzerDatenUI Constructor
        ///</summary>
        [TestMethod()]
        public void NutzerDatenUIConstructorTest()
        {
            MDP_Projekt.UI.NutzerDatenUI target = new MDP_Projekt.UI.NutzerDatenUI();
            Assert.IsInstanceOfType(target, typeof(NutzerDatenUI));
        }
         
        /// <summary>
        ///A test for getNutzer
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MDP-Projekt.exe")]
        public void getNutzerTest()
        {
            MDP_Projekt.UI.NutzerDatenUI_Accessor target1 = new MDP_Projekt.UI.NutzerDatenUI_Accessor();
            MDP_Projekt.UI.NutzerDatenUI_Accessor target2 = new MDP_Projekt.UI.NutzerDatenUI_Accessor();
            System.Collections.Generic.List<MDP_Projekt.Model.T_NUTZER> expected;
            System.Collections.Generic.List<MDP_Projekt.Model.T_NUTZER> actual;
            actual = target1.getNutzer();
            expected = target2.getNutzer();

            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(target1, typeof(NutzerDatenUI_Accessor));
            Assert.IsInstanceOfType(target2, typeof(NutzerDatenUI_Accessor));
            Assert.IsTrue(actual.Capacity > 0);
            Assert.IsTrue(actual.Capacity == expected.Capacity);
            Assert.AreEqual(expected, actual);
        }
         */
    }
}
