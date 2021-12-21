using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string Login = "f";
            string Password = "123";
            Form1 f = new Form1(true);
            bool result = f.Auth(Login, Password);
            //string login = "f";
            //string password = "123";
            //if (textBox1.Text == login && textBox2.Text == password)
            //{
            //    Form2 f2 = new Form2(true);
            //    f2.ShowDialog();
            //}
            //          

            //Form1 f = new Form1();
            //string login = "f";
            //string password = "123";
            //Assert.AreEqual(login, password);
        }
    }
}
