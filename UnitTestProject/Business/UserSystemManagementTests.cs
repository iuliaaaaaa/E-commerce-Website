using Microsoft.VisualStudio.TestTools.UnitTesting;
using IndividualAssignment_OOD;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndividualAssignment_OOD.Tests
{
    [TestClass()]
    public class UserSystemManagementTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            try
            {
                UserSystemManagement.Login("random", "random");
                return; // indicates success
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void LoginTest2()
        {
            try
            {
                UserSystemManagement.Login("admin@admin", "admin");
                return; // indicates success
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void LoginTest3()
        {
            try
            {
                UserSystemManagement.Login("business@business", "client");
                return; // indicates success
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Empty field exception") ]
        public void LoginTest4()
        {
            
                UserSystemManagement.Login("", "");
                
        }


        [TestMethod()]
        public void SignUpTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SignUpBusinessTest()
        {
            Assert.Fail();
        }
    }
}