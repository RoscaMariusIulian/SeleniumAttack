/**************************************************************************
 *                                                                        *
 *  File:        Reader.cs                                                *
 *  Copyright:   (c) 2020, Rosca Marius - Iulian                          *
 *  E-mail:      marius-iulian.rosca@student.tuiasi.ro                    *
 *  Website:     https://github.com/RoscaMariusIulian                     *
 *  Description: Read file to a list of strings.                          *
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
using System.Collections.Generic;
using System.IO;
#endregion

namespace Files
{
    public class Reader
    {
        #region variables
        public List<string> Items = null; 
        #endregion

        #region methods
        public Reader(string doc)
        {
            try
            {
                StreamReader file = new StreamReader(doc); 
                string line; 
                List<string> items = new List<string>(); 
                while ((line = file.ReadLine()) != null) 
                {
                    items.Add(line);
                }
                Items = items; 
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }    
        }
        #endregion
    }
}
