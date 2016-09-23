﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using WebShop.Abstractions.Interfaces;
using System.IO;
using System.Linq.Expressions;
using System.Xml;


namespace WebShop.Classes
{
    public class UserRepository : IBaseUser
    {


        //public List<User> Users()
        //{
        //    userList.Add(inputUser);
        //    return userList;
        //}




        public bool LogIn(string userName, string password)
        {
            try
            {
                if ( email 
                {
                    GetUser()
                }
              

            }
            catch (Exception)
            {
                
                throw;
            }
       


            //try
            //{
            //    if (File.Exists(SiteConstants.PathToUsersXml()))
            //    {
            //        using (XmlReader reader = XmlReader.Create(SiteConstants.PathToUsersXml()))
            //        {
            //            User user = new User();
            //            while (reader.Read())
            //            {
            //                if (reader.IsStartElement())
            //                {
            //                    switch (reader.Name)
            //                    {
            //                        case "Users":
            //                            break;
            //                        case "User":
            //                            if (reader.IsStartElement())
            //                            {
            //                                user = new User();
            //                            }
            //                            else
            //                            {

            //                            }
            //                            break;

            //                    }
            //                }
            //            }
            //        }
            //    }

            //    if (userName ==
            //    {

            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }


        public bool LogOut()
        {

        }


        public bool CreateUser(User account)
        {
            try
            {
                if (File.Exists(SiteConstants.PathToUsersXml()))
                {
                    var xDocument = XDocument.Load(SiteConstants.PathToUsersXml());
                    var user = xDocument.Element("Users");

                    if (user != null) // Add new user
                    {
                        user.Add(new XElement("User",
                            new XElement("UserName", account.UserName),
                            new XElement("Password", account.Password),
                            new XElement("Email", account.Email),
                            new XElement("Address", account.Address)));

                        xDocument.Save(SiteConstants.PathToUsersXml());
                    }
                }
                else
                {
                    var user = new XElement("Users",
                        new XElement("User",
                            new XElement("UserName", account.UserName),
                            new XElement("Password", account.Password),
                            new XElement("Email", account.Email),
                            new XElement("Address", account.Address)));

                    using (var sw = new StreamWriter(SiteConstants.PathToUsersXml(), true))
                    {
                        user.Save(sw);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                using (var sw = new StreamWriter(SiteConstants.PathToUsersXml(), true))
                {
                    sw.WriteLine(DateTime.Now + "" + e.Message);
                }
                return false;
            }
        }


        public bool UppdateUser(User user)
        {
            try
            {


            }
            catch (Exception e)
            {
                using (var sw = new StreamWriter(SiteConstants.PathToUsersXml(), true))
                {
                    sw.WriteLine(DateTime.Now + "" + e.Message);
                }
                return false;
            }
        }


        public bool RemoveUser(User user)
        {

        }


        public List<User> GetUser()
        {
            try
            {
                var users = new List<User>();
                var document = XDocument.Load(SiteConstants.PathToUsersXml());
                var elements = from i in document.Descendants("User")
                    select new
                    {
                        UserName = i.Element("UserName").Value,
                        Password = i.Element("Password").Value,
                        Email = i.Element("Email").Value,
                        Address = i.Element("Address").Value
                    };
                foreach (var user in elements)
                {
                    var u = new User
                    {
                        UserName = user.UserName,
                        Password = int.Parse(user.Password),
                        Email = user.Email,
                        Address = user.Address
                    };
                    users.Add(u);             
                }
                return users;
            }
            catch (Exception e)
            {
                using (var sw = new StreamWriter(SiteConstants.PathToUsersXml(),true))
                {
                    sw.WriteLine(DateTime.Now + "" + e.Message);
                }
                return  new List<User>();
            }
        }
    }
    


}