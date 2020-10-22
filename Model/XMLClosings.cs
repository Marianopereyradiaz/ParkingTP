using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace TP_Parking
{
    public class XMLClosings
    {
        private string fileRoute = @"C:\ParkingFiles\closings.xml";

        public void GenerateXML(List<Closing> closings)
        {
            try
            {

                XmlTextWriter writer = new XmlTextWriter(fileRoute, null);


                writer.Formatting = Formatting.Indented;


                writer.WriteStartDocument();


                writer.WriteStartElement("Closings");


                foreach (Closing closing in closings)
                {
                    writer.WriteStartElement("Closing");
                    writer.WriteElementString("Date", closing.Date.ToString());

                    writer.WriteStartElement("User");
                    writer.WriteElementString("UserName", closing.User.UserName);
                    writer.WriteElementString("Password", closing.User.Password);
                    writer.WriteElementString("LastAdmission", closing.User.LastAdmission.ToString());
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Closing> ReturnClosings()
        {
            List<Closing> closings = new List<Closing>();

            try
            {
                FileStream archive = new FileStream(fileRoute, FileMode.Open, FileAccess.Read);

                XmlTextReader reader = new XmlTextReader(archive);

                Closing closing = null;
                User user = null;
                

                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Closings":
                                break;

                            case "Closing":
                                if (reader.Read())
                                    closing = new Closing();
                                break;

                            case "Date":
                                if (reader.Read())
                                    closing.Date = Convert.ToDateTime(reader.Value);
                                break;

                            case "User":
                                if (reader.Read())
                                    closing.User = new User();
                                break;

                            case "UserName":
                                if (reader.Read())
                                    closing.User.UserName = reader.Value;
                                break;

                            case "Password":
                                if (reader.Read())
                                    closing.User.Password = reader.Value;
                                break;

                            default:
                                if (reader.Read())
                                    closing.User.LastAdmission = Convert.ToDateTime(reader.Value);
                                break;
                        }
                    }

                    else if (reader.Name == "Closing")
                    {
                        closings.Add(closing);
                        closing = null;
                    }
                }

                reader.Close();
                archive.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return closings;
        }
    }
}
