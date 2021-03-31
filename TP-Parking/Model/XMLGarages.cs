using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace TP_Parking
{
    public class XMLGarages
    {
        private string fileRoute = @"C:\ParkingFiles\garages.xml";

        public void GenerateXML(List<Garage> garages)
        {
            try
            {

                XmlTextWriter writer = new XmlTextWriter(fileRoute, null);


                writer.Formatting = Formatting.Indented;


                writer.WriteStartDocument();


                writer.WriteStartElement("Garages");


                foreach (Garage garage in garages)
                {

                    writer.WriteStartElement("Garage");

                    writer.WriteElementString("Number", garage.Number.ToString());
                    writer.WriteElementString("State", garage.State.ToString());

                    writer.WriteStartElement("Vehicle");
                    writer.WriteElementString("Domain", garage.Vehicle.Domain);
                    writer.WriteElementString("Brand", garage.Vehicle.Brand);
                    writer.WriteElementString("Model", garage.Vehicle.Model);
                    
                    writer.WriteStartElement("VehicleType");
                    writer.WriteElementString("Code", garage.Vehicle.VehicleType.Code.ToString());
                    writer.WriteElementString("Description", garage.Vehicle.VehicleType.Description);
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

        public List<Garage> ReturnGarages()
        {
            List<Garage> garages = new List<Garage>();

            try
            {
                FileStream archive = new FileStream(fileRoute, FileMode.Open, FileAccess.Read);

                XmlTextReader reader = new XmlTextReader(archive);

                Garage garage = null;
                Vehicle vehicle = null;
                VehicleType vehicleType = null;

                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Garages":
                                break;

                            case "Garage":
                                    garage = new Garage();
                                break;

                            case "Number":
                                if (reader.Read()) 
                                    garage.Number = Convert.ToInt32(reader.Value);
                                break;

                            case "State":
                                if (reader.Read())
                                    garage.State = Convert.ToBoolean(reader.Value);
                                break;

                            case "Vehicle":
                                if (reader.Read())
                                    garage.Vehicle = new Vehicle();
                                break;

                            case "Domain":
                                if (reader.Read())
                                    garage.Vehicle.Domain = reader.Value;
                                break;

                            case "Brand":
                                if (reader.Read())
                                    garage.Vehicle.Brand = reader.Value;
                                break;

                            case "Model":
                                if (reader.Read())
                                    garage.Vehicle.Model = reader.Value;
                                break;

                            case "VehicleType":
                                if (reader.Read())
                                    garage.Vehicle.VehicleType = new VehicleType();
                                break;

                            case "Code":
                                if (reader.Read())
                                    garage.Vehicle.VehicleType.Code = Convert.ToInt32(reader.Value);
                                break;

                            default:
                                if (reader.Read())
                                    garage.Vehicle.VehicleType.Description = reader.Value;
                                break;

                        }
                    }

                    else if (reader.Name == "Garage")
                    {
                        garages.Add(garage);
                        garage = null;
                    }
                }

                reader.Close();
                archive.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return garages;
        }
    }
}
