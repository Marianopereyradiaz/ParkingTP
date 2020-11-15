using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace TP_Parking.Model
{
    class XMLUser
    {
    
        private string RouteFile = @"C:\ParkingFiles\";
        private string fileRoute = @"C:\ParkingFiles\users.xml";

        public void GenerateXML(List <User> users)
        {
            try
            {
                if (!Directory.Exists(RouteFile))
                {
                    Directory.CreateDirectory(RouteFile);
                }
                if (File.Exists(fileRoute))
                {
                    File.Delete(fileRoute);
                }
                if (!File.Exists(fileRoute))
                {

                    XmlTextWriter writer = new XmlTextWriter(fileRoute, null);


                    writer.Formatting = Formatting.Indented;


                    writer.WriteStartDocument();


                    writer.WriteStartElement("Users");


                    foreach (User user in users)
                    {

                        writer.WriteStartElement("User");


                        writer.WriteElementString("UserName", user.UserName);
                        writer.WriteElementString("Password", user.Password);
                        writer.WriteElementString("LastAdmission", user.LastAdmission.ToString());
                      
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<User> Return()
        {
            List<User> users = new List<User>();

            try
            {
                if (!Directory.Exists(RouteFile))
                {
                    Directory.CreateDirectory(RouteFile);
                }

                if (!File.Exists(fileRoute))
                {
                    GenerateXML(users);
                }
                FileStream archive = new FileStream(fileRoute, FileMode.Open, FileAccess.Read);

                XmlTextReader reader = new XmlTextReader(archive);

                User user = null;

                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Users":
                                break;

                            case "User":

                                user = new User();
                                break;

                            case "UserName":
                                if (reader.Read())
                                    user.UserName = reader.Value;
                                break;

                            case "Password":
                                if (reader.Read())
                                    user.Password = reader.Value;
                                break;

                            default:
                                if (reader.Read())
                                    user.LastAdmission = Convert.ToDateTime(reader.Value);
                                break;
                        }
                    }

                    else if (reader.Name == "User")
                    {
                        users.Add(user);
                        user = null;
                    }
                }

                reader.Close();
                archive.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return users;
        }
    }
}
