/**************************************************************************
 *                                                                        *
 *  File:        Gui.cs                                                   *
 *  Copyright:   (c) 2020, Rosca Marius - Iulian                          *
 *  E-mail:      marius-iulian.rosca@student.tuiasi.ro                    *
 *  Website:     https://github.com/RoscaMariusIulian                     *
 *  Description: Graphical interface for the program and                  *
 *               the functionality behind it.                             *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
#region includes
using System;
using System.Windows.Forms;
using Targets;
using Hacking;
using Urls;
#endregion

namespace DictionaryAttack
{
   
    public partial class GUI : Form
    {
        #region variables
        private string _username; 
        private string _password; 
        private string _login; 
        private string _url; 
        #endregion
        public GUI()
        {
            InitializeComponent();
        }
        private void buttonHit_Click(object sender, EventArgs e)
        {
            Console.Clear();
            if (string.IsNullOrWhiteSpace(textBoxUrl.Text))
            {
                Console.WriteLine("Introduceti un url valid."); 
            }
            else
            {
                _url = textBoxUrl.Text; 
                Console.WriteLine("Checking the url.."); 
                Check request = new Check(_url); 
                if (request.isStatus) 
                {
                    Console.WriteLine("Url is valid, moving forward.."); 
                    (sender as Button).Enabled = false; 
                    if (string.IsNullOrWhiteSpace(textBoxUser.Text) || string.IsNullOrWhiteSpace(textBoxPass.Text) || string.IsNullOrWhiteSpace(textBoxButton.Text))
                    {
                        Console.WriteLine("Crawler called.."); 
                        xPaths xPathList = new xPaths(_url); 
                        _username = xPathList.UsernameXPath; 
                        _password = xPathList.PasswordXPath;
                        _login = xPathList.ButtonXPath;
                        Console.WriteLine("Crawler ended succesfuly!");
                    }
                    else 
                    {

                        _username = textBoxUser.Text; 
                        _password = textBoxPass.Text;
                        _login = textBoxButton.Text;
                    }
                    Console.WriteLine("Dictionary attack has started.."); 
                    Attack dictionaryAttack = new Attack(_url, _username, _password, _login, checkBoxBackground.Checked); 
                    dictionaryAttack.Start();
                    foreach (string user in dictionaryAttack.ValidUser)
                        labelUsernames.Text += user + " "; 
                    foreach (string pass in dictionaryAttack.ValidPass)
                        labelPasswords.Text += pass + " ";
                    (sender as Button).Enabled = true; 
                }
                else 
                {
                    Console.WriteLine("URL invalid!");
                }
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("help.chm"); //se afiseaza help-ul asociat
        }

  
    }
}
