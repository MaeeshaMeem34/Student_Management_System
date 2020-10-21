using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    [TestFixture]
    class testClass
    {
        
        DatabaseConnection db = new DatabaseConnection();

        LoginForm log = new LoginForm();
        [Test]
        public void testEntry()
        {
            bool r = log.checkDb("admin", "admin");
            Assert.IsTrue(r);
            
        }

        [Test]
        public void testEntry2ndAdmin()
        {
            bool r = log.checkDb("admin2", "1234");
            Assert.IsTrue(r);

        }

        [Test]
        public void testFalseEntry()
        {
            bool r = log.checkDb("admin2", "123456");
            Assert.IsFalse(r);

        }

        [Test]
        public void testNullEntry()
        {
            Assert.Throws<NullReferenceException>(() => log.checkDb("", "1234"));

        }
        


    }
}
