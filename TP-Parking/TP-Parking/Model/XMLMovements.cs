using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace TP_Parking
{
    public class XMLMovements
    {
        private string fileRoute = @"C:\ParkingFiles\movements.xml";

        public void GenerateXML(List<Movement> movements)
        {
            try
            {

                XmlTextWriter writer = new XmlTextWriter(fileRoute, null);


                writer.Formatting = Formatting.Indented;


                writer.WriteStartDocument();


                writer.WriteStartElement("Movements");


                foreach (Movement movement in movements)
                {

                    writer.WriteStartElement("Movement");


                    writer.WriteElementString("Concept", movement.Concept);
                    writer.WriteElementString("Amount", movement.Amount.ToString());
                    writer.WriteElementString("DateMovement", movement.Date.ToString());
                    writer.WriteElementString("IsEntry", movement.IsEntry.ToString());

                    writer.WriteStartElement("User");
                    writer.WriteElementString("UserNameUser", movement.user.UserName);
                    writer.WriteElementString("PasswordUser", movement.user.Password);
                    writer.WriteElementString("LastAdmissionUser", movement.user.LastAdmission.ToString());
                    writer.WriteEndElement();

                    writer.WriteStartElement("Closing");
                    writer.WriteElementString("DateClosing", movement.closing.Date.ToString());
                    
                    writer.WriteStartElement("UserClosing");
                    writer.WriteElementString("UserNameClosing", movement.closing.User.UserName);
                    writer.WriteElementString("PasswordClosing", movement.closing.User.Password);
                    writer.WriteElementString("LastAdmissionClosing", movement.closing.User.LastAdmission.ToString());
                    writer.WriteEndElement();

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

        public List<Movement> ReturnMovements()
        {
            List<Movement> movements = new List<Movement>();

            try
            {
                FileStream archive = new FileStream(fileRoute, FileMode.Open, FileAccess.Read);

                XmlTextReader reader = new XmlTextReader(archive);

                Movement movement = null;
                User user = null;
                Closing closing = null;

                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Movements":
                                break;

                            case "Movement":

                                movement = new Movement();
                                break;

                            case "Concept":
                                if (reader.Read())
                                    movement.Concept = reader.Value;
                                break;

                            case "Amount":
                                if (reader.Read())
                                    movement.Amount = Convert.ToDouble(reader.Value);
                                break;

                            case "DateMovement":
                                if (reader.Read())
                                    movement.Date = Convert.ToDateTime(reader.Value);
                                break;

                            case "IsEntry":
                                if (reader.Read())
                                    movement.IsEntry = Convert.ToBoolean(reader.Value);
                                break;

                            case "User":
                                    movement.user = new User();
                                break;

                            case "UserNameUser":
                                if (reader.Read())
                                    movement.user.UserName= reader.Value;
                                break;

                            case "PasswordUser":
                                if (reader.Read())
                                    movement.user.Password = reader.Value;
                                break;

                            case "LastAdmissionUser":
                                if (reader.Read())
                                    movement.user.LastAdmission = Convert.ToDateTime(reader.Value);
                                break;

                            case "Closing":
                                    movement.closing = new Closing();
                                break;

                            case "DateClosing":
                                if (reader.Read())
                                    movement.closing.Date = Convert.ToDateTime(reader.Value);
                                break;

                            case "UserClosing":
                                    movement.closing.User = new User();
                                break;

                            case "UserNameClosing":
                                if (reader.Read())
                                    movement.closing.User.UserName = reader.Value;
                                break;

                            case "PasswordClosing":
                                if (reader.Read())
                                    movement.closing.User.Password = reader.Value;
                                break;
                
                            default:                 
                                if (reader.Read())
                                        movement.closing.User.LastAdmission = Convert.ToDateTime(reader.Value);
                                break;

                        }
                    }

                    else if (reader.Name == "Movement")
                    {
                        movements.Add(movement);
                        movement = null;
                    }
                }

                reader.Close();
                archive.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return movements;
        }
    }
}
