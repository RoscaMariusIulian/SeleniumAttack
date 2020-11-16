/**************************************************************************
 *                                                                        *
 *  File:        UnitTest.cs                                              *
 *  Copyright:   (c) 2020, Rosca Marius - Iulian                          *
 *  E-mail:      marius-iulian.rosca@student.tuiasi.ro                    *
 *  Website:     https://github.com/RoscaMariusIulian                     *
 *  Description: Unit testing for the application                         *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
#region includes
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Targets;
using Hacking;
using Urls;
using Files;
#endregion

namespace UnitTesting
{  
    [TestClass]
    public class UnitTesthttp
    {
        #region testmethods
        [TestMethod]
        public void TestGoogle() //test for a well known site
        {
            Check request = new Check("https://www.google.com/");
            Assert.IsTrue(request.isStatus);
        }
        [TestMethod]
        public void TestFacebook()//test for another well known site to be sure
        {
            Check request = new Check("https://www.facebook.com/");
            Assert.IsTrue(request.isStatus);
        }
        [TestMethod]
        public void TestTarget()//test the host of the website we're attacking
        {
            Check request = new Check("http://192.168.1.105/login.php");
            Assert.IsTrue(request.isStatus);
        }
        [TestMethod]
        public void TestLocalHost()//test the host of the website we're attacking as localhost
        {
            Check request = new Check("http://localhost/login.php");
            Assert.IsTrue(request.isStatus);
        }
        [TestMethod]
        public void TestFalse()//test if we can't skip the login
        {
            Check request = new Check("https://localhost/index.php");
            Assert.IsFalse(request.isStatus);
        }
        [TestMethod]
        public void TestInvalid()//check if a random string can be an URL
        {
            Check request = new Check("sadsadasdsadasdxzczxzxsadwqesad");
            Assert.IsFalse(request.isStatus);
        }
        [TestMethod]
        public void URLNull()//chef if no string can be an URL
        {
            Check request = new Check("");
            Assert.IsFalse(request.isStatus);
        }
        [TestMethod]
        public void UsernamesFile()//check for usernames wordlist
        {
            Reader usernames = new Reader("usernames.txt");
            Assert.IsTrue(usernames.Items.Count>0);
        }
        [TestMethod]
        public void PasswordsFile()//check for passwords wordlist
        {
            Reader passwords = new Reader("passwords.txt");
            Assert.IsTrue(passwords.Items.Count > 0);
        }
        [TestMethod]
        public void RightFileWrongExtension()//check for a file with the wrong extension
        {
            Reader passwords = new Reader("passwords.md");
            Assert.IsTrue(passwords.Items == null);
        }
        [TestMethod]
        public void FileNotFound()//check for a missing file
        {
            Reader file = new Reader("abc.txt");
            Assert.IsTrue(file.Items == null);
        }
        [TestMethod]
        public void NotTxtFile()//check for a programing file
        {
            Reader file = new Reader("abc.php");
            Assert.IsTrue(file.Items == null);
        }
        [TestMethod]
        public void FileRandomString()//check file as a random string
        {
            Reader file = new Reader("dsadasda");
            Assert.IsTrue(file.Items == null);
        }
        [ExpectedException(typeof(System.ArgumentException))]
        [TestMethod]
        public void NoFile()//check file as a empty string
        {
            Reader file = new Reader("");
            Assert.IsTrue(file.Items == null);
        }
        [TestMethod]
        public void FindXPaths()//find all the xpaths
        {
            xPaths xPathList = new xPaths("http://192.168.1.105/login.php");
            Assert.IsTrue(xPathList.UsernameXPath != null && xPathList.PasswordXPath != null && xPathList.ButtonXPath != null);
        }
        [TestMethod]
        public void GetUserXPath()//verify if the username xpath is valid
        {
            xPaths xPathList = new xPaths("http://192.168.1.105/login.php");
            Assert.IsTrue((xPathList.UsernameXPath).Contains("user"));
        }
        [TestMethod]
        public void GetPassXPath()//verify if the password xpath is valid
        {
            xPaths xPathList = new xPaths("http://192.168.1.105/login.php");
            Assert.IsTrue((xPathList.PasswordXPath).Contains("pass"));
        }
        [TestMethod]
        public void GetButtonXPath()//verify if the button xpath is valid
        {
            xPaths xPathList = new xPaths("http://192.168.1.105/login.php");
            Assert.IsTrue((xPathList.ButtonXPath).Contains("bmit") || (xPathList.ButtonXPath).Contains("ogin"));
        }
        [TestMethod]
        public void ConstructAttack()//set the values for the attack
        {
            Attack dictionaryAttack = new Attack("http://192.168.1.105/login.php", "//input[@name='username']", "//input[@name='password']", "//input[@name='Login']", true);
            Assert.IsTrue(dictionaryAttack.ValidPass.Count==0);
        }
        [TestMethod]
        public void  LaunchAttack()//launch an actual attack
        {
            Attack dictionaryAttack = new Attack("http://192.168.1.105/login.php", "//input[@name='username']", "//input[@name='password']", "//input[@name='Login']", true);
            dictionaryAttack.Start();
            Assert.IsTrue(dictionaryAttack.ValidPass.Count>0);
        }
        #endregion
    }
}
