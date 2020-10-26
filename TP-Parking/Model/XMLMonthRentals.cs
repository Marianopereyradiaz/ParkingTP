using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace TP_Parking
{
    public class XMLMonthRentals
    {
        private string fileRoute = @"C:\ParkingFiles\monthRentals.xml";

        public void GenerateXML(List<MonthRental> monthRentals)
        {
            try
            {

                XmlTextWriter writer = new XmlTextWriter(fileRoute, null);


                writer.Formatting = Formatting.Indented;


                writer.WriteStartDocument();


                writer.WriteStartElement("MonthRentals");


                foreach (MonthRental monthRental in monthRentals)
                {

                    writer.WriteStartElement("MonthRental");


                    writer.WriteElementString("DateTime", monthRental.Date.ToString());
                    writer.WriteElementString("Owner", monthRental.Owner);
                    writer.WriteElementString("ExpirationDate", monthRental.ExpirationDate.ToString());
                    writer.WriteElementString("Value", monthRental.Value.ToString());

                    writer.WriteStartElement("Garage");
                    writer.WriteElementString("Number", monthRental.Garage.Number.ToString());
                    writer.WriteElementString("State", monthRental.Garage.State.ToString());


                    writer.WriteStartElement("Vehicle");
                    writer.WriteElementString("Brand", monthRental.Garage.Vehicle.Brand);
                    writer.WriteElementString("Domain", monthRental.Garage.Vehicle.Domain);
                    writer.WriteElementString("Model", monthRental.Garage.Vehicle.Model);

                    writer.WriteStartElement("VehicleType");
                    writer.WriteElementString("Code", monthRental.Garage.Vehicle.VehicleType.Code.ToString());
                    writer.WriteElementString("Description", monthRental.Garage.Vehicle.VehicleType.Description.ToString());

                    writer.WriteEndElement();
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

        public List<MonthRental> ReturnRentals()
        {
            List<MonthRental> MonthRentals = new List<MonthRental>();

            try
            {
                
                FileStream archivo = new FileStream(fileRoute, FileMode.Open, FileAccess.Read);

                
                XmlTextReader reader = new XmlTextReader(archivo);

                
                MonthRental monthRental = null;
                Garage garage = null;
                Vehicle vehicle = null;
                VehicleType vehicleType = null;

                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "MonthRentals": 
                                break;

                            case "MonthRental": 
                                monthRental = new MonthRental();
                                break;

                            case "Garage":
                                monthRental.Garage = new Garage(); 
                                break;

                            case "Vehicle":
                                monthRental.Garage.Vehicle = new Vehicle();
                                break;

                            case "VehicleType":
                                monthRental.Garage.Vehicle.VehicleType = new VehicleType();
                                break;

                            case "DateTime":
                                if (reader.Read())
                                    monthRental.Date = Convert.ToDateTime(reader.Value); 
                                break;

                            case "Owner":
                                if (reader.Read())
                                    monthRental.Owner = reader.Value;
                                break;

                            case "ExpirationDate":
                                if (reader.Read())
                                    monthRental.ExpirationDate = Convert.ToDateTime(reader.Value);
                                break;

                            case "Value":
                                if (reader.Read())
                                    monthRental.Value = Convert.ToDouble(reader.Value);
                                break;

                            case "Number":
                                if (reader.Read())
                                    monthRental.Garage.Number = Convert.ToInt32(reader.Value);
                                break;

                            case "State": 
                                if (reader.Read())
                                    monthRental.Garage.State = Convert.ToBoolean(reader.Value);
                                break;

                            case "Brand": 
                                if (reader.Read())
                                    monthRental.Garage.Vehicle.Brand = reader.Value;
                                break;

                            case "Domain": 
                                if (reader.Read())
                                    monthRental.Garage.Vehicle.Domain = reader.Value;
                                break;

                            case "Model": 
                                if (reader.Read())
                                    monthRental.Garage.Vehicle.Model = reader.Value;
                                break;

                            case "Code": 
                                if (reader.Read())
                                    monthRental.Garage.Vehicle.VehicleType.Code = Convert.ToInt32(reader.Value);
                                break;

                            default: 
                                if (reader.Read())
                                    monthRental.Garage.Vehicle.VehicleType.Description = Convert.ToString(reader.Value);
                                break;

                        }
                    }

                    else if (reader.Name == "MonthRental")
                    {
                        MonthRentals.Add(monthRental);
                        monthRental = null;
                    }
                }

                reader.Close(); 
                archivo.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return MonthRentals;
        }
    }
}

