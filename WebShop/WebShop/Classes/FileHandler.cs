using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Classes
{
    public class FileHandler
    {
        protected string discFileName;
        protected string discPath;

        public FileHandler()
        {
            discPath = GetTempPath();
        }

        private string GetTempPath()
        {

            string path = System.Environment.GetEnvironmentVariable("TEMP");
            if (!path.EndsWith("\\"))
            {
                path += "\\";
            }


            return HttpContext.Current.Server.MapPath("~/");  // path;
        }
    }
}