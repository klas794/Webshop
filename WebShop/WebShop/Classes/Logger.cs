using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop.Abstractions.Interfaces;
using System.IO;
using System.Diagnostics;

namespace WebShop.Classes
{
    public class Logger : FileHandler, ILogger
    {
        
        public Logger()
        {
            discFileName = "webshop-log.txt";
        }

        public void Clear()
        {
            try
            {
                File.WriteAllText(discPath + discFileName, "");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public string[] ReadLogContent()
        {
            try
            {
                return File.ReadAllLines(discPath + discFileName);
            }
            catch (Exception e) {

                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public void WriteLogMessage(string message)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(discPath + discFileName, true))
                {
                    sw.Write("{0} - {1} : ", 
                        DateTime.Now.ToShortDateString(),
                        DateTime.Now.ToLongTimeString());
                    sw.WriteLine(message);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }
        
    }
}