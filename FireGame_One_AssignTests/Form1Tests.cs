using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireGame_One_Assign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame_One_Assign.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            rulesClass obj = new rulesClass();
            if (obj.genTrigger() < 5)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }

        }
        [TestMethod()]
        public void Form2Test()
        {
            rulesClass obj = new rulesClass();
            if (obj.genNewTrigger() < 5)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

        }

    }
}