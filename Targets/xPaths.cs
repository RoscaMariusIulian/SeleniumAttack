/**************************************************************************
 *                                                                        *
 *  File:        xPaths.cs                                                *
 *  Copyright:   (c) 2020, Rosca Marius - Iulian                          *
 *  E-mail:      marius-iulian.rosca@student.tuiasi.ro                    *
 *  Website:     https://github.com/RoscaMariusIulian                     *
 *  Description: Finds and sets the required xpaths from the page.        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
#region includes
using System.Collections.Generic;
using System.Diagnostics;
#endregion

namespace Targets
{
    public class xPaths
    {
        #region variables
        public string UsernameXPath; 
        public string PasswordXPath;
        public string ButtonXPath;
        #endregion

        #region methods
        public xPaths(string url)
        {
            var proc = new Process 
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "python.exe", 
                    Arguments = "crawler.py " + url, 
                    UseShellExecute = false, 
                    RedirectStandardOutput = true, 
                    CreateNoWindow = true 
                }
            };
            proc.Start(); 

            List<string> pathList = new List<string>(); 
            while (!proc.StandardOutput.EndOfStream) 
            {
               pathList.Add(proc.StandardOutput.ReadLine()); 
            }
            proc.Close();
            foreach (string path in pathList) 
            {
                if (path.StartsWith("//"))
                {
                    if (path.Contains("user"))
                        UsernameXPath = path; 
                    if (path.Contains("pass")) 
                        PasswordXPath = path;
                    if (path.Contains("ogin") || path.Contains("bmit"))
                        ButtonXPath = path;
                }
            }
        }
        #endregion
    }

}
