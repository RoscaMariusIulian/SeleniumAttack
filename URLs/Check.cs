/**************************************************************************
 *                                                                        *
 *  File:        Check.cs                                                 *
 *  Copyright:   (c) 2020, Rosca Marius - Iulian                          *
 *  E-mail:      marius-iulian.rosca@student.tuiasi.ro                    *
 *  Website:     https://github.com/RoscaMariusIulian                     *
 *  Description: Checks if the url is valid.                              *
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
using System.Net;
#endregion

namespace Urls
{
    public class Check
    {
        #region variables
        public bool isStatus; 
        #endregion

        #region methods
        public Check(string url)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest; 
                request.Method = "HEAD"; 
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                response.Close();
                isStatus = (response.StatusCode == HttpStatusCode.OK);   
            }
            catch (Exception)
            {
                isStatus = false; 
            }
        }
        #endregion
    }
}
