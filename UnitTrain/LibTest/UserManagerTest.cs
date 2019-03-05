using System;
using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibTest
{
    [TestClass]
    public class UserManagerTest
    {
        private TestContext TestContext { get; set; }
        private UserManager UserManager = new UserManager();

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "testData.xml",
            "User",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void UserManager_Add_FromXml()
        {
            string userId = Convert.ToString(TestContext.DataRow["userid"]);
            string telephone = Convert.ToString(TestContext.DataRow["telephone"]);
            string email = Convert.ToString(TestContext.DataRow["email"]);

            bool result = UserManager.Add(userId, telephone, email);

            Assert.IsTrue(result, "user Can't be created");
        }
    }
}