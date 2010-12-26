using MDP_Projekt.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MDP_Projekt.Model;
using System.Collections.Generic;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for MaterialDatenUITest and is intended
    ///to contain all MaterialDatenUITest Unit Tests
    ///</summary>
    [TestClass()]
    public class MaterialDatenUITest
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
        ///A test for MaterialDatenUI Constructor
        ///</summary>
        [TestMethod()]
        public void MaterialDatenUIConstructorTest()
        {
            MaterialDatenUI target = new MaterialDatenUI();
            Assert.IsInstanceOfType(target, typeof(MaterialDatenUI));
        }

        /// <summary>
        ///A test for getMaterial
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MDP-Projekt.exe")]
        public void getMaterialTest()
        {
            MDP_Projekt.UI.MaterialDatenUI_Accessor target1 = new MDP_Projekt.UI.MaterialDatenUI_Accessor();
            MDP_Projekt.UI.MaterialDatenUI_Accessor target2 = new MDP_Projekt.UI.MaterialDatenUI_Accessor();
            List<TR_MATERIAL> expected;
            List<TR_MATERIAL> actual;
            actual = target1.getMaterial();
            expected = target2.getMaterial();

            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(target1, typeof(MaterialDatenUI_Accessor));
            Assert.IsInstanceOfType(target2, typeof(MaterialDatenUI_Accessor));
            Assert.IsTrue(actual.Capacity > 0);
            Assert.IsTrue(actual.Capacity == expected.Capacity);
            Assert.AreEqual(expected, actual);
        }
         */
    }
}
