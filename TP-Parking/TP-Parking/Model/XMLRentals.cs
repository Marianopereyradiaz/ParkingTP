using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace TP_Parking
{
    public class XMLRentals
    {
        private string fileRoute = @"C:\ParkingFiles\rentals.xml"; 

        public void GenerateXML(List<Rental> rentals)
        {
            try
            {
               
                XmlTextWriter writer = new XmlTextWriter(fileRoute, null);

              
                writer.Formatting = Formatting.Indented;

               
                writer.WriteStartDocument();

                
                writer.WriteStartElement("Rentals");

                
                foreach (Rental rental in rentals)
                {
                    
                    writer.WriteStartElement("Rental");

                    
                    writer.WriteElementString("DateTime", rental.Date.ToString()); 

                   
                    writer.WriteStartElement("Garage");
                    writer.WriteElementString("Number", rental.Garage.Number.ToString());
                    writer.WriteElementString("State", rental.Garage.State.ToString());

                    
                    writer.WriteStartElement("Vehicle");
                    writer.WriteElementString("Brand", rental.Garage.Vehicle.Brand);
                    writer.WriteElementString("Domain", rental.Garage.Vehicle.Domain);
                    writer.WriteElementString("Model", rental.Garage.Vehicle.Model);

                    writer.WriteStartElement("VehicleType");
                    writer.WriteElementString("Code", rental.Garage.Vehicle.VehicleType.Code.ToString()); 
                    writer.WriteElementString("Description", rental.Garage.Vehicle.VehicleType.Description.ToString()); 

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

        public List<Rental> ReturnRentals()
        {
            List<Rental> rentals = new List<Rental>();

            try
            {
                
                FileStream archivo = new FileStream(fileRoute, FileMode.Open, FileAccess.Read);

                
                XmlTextReader reader = new XmlTextReader(archivo);

                
                Rental rental = null;
                Garage garage = null;
                Vehicle vehicle = null;
                VehicleType vehicleType = null;

                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Rentals": 
                                break;

                            case "Rental": 
                                rental = new Rental();
                                break;

                            case "Garage":
                                rental.Garage = new Garage(); 
                                break;

                            case "Vehicle":
                                rental.Garage.Vehicle = new Vehicle();
                                break;

                            case "VehicleType":
                                rental.Garage.Vehicle.VehicleType = new VehicleType();
                                break;

                            case "DateTime":
                                if (reader.Read())
                                    rental.Date = Convert.ToDateTime(reader.Value); 
                                break;

                            case "Number":
                                if (reader.Read())
                                    rental.Garage.Number = Convert.ToInt32(reader.Value);
                                break;

                            case "State": 
                                if (reader.Read())
                                    rental.Garage.State = Convert.ToBoolean(reader.Value);
                                break;

                            case "Brand": 
                                if (reader.Read())
                                    rental.Garage.Vehicle.Brand = reader.Value;
                                break;

                            case "Domain": 
                                if (reader.Read())
                                    rental.Garage.Vehicle.Domain = reader.Value;
                                break;

                            case "Model": 
                                if (reader.Read())
                                    rental.Garage.Vehicle.Model = reader.Value;
                                break;

                            case "Code": 
                                if (reader.Read())
                                    rental.Garage.Vehicle.VehicleType.Code = Convert.ToInt32(reader.Value);
                                break;

                            default: 
                                if (reader.Read())
                                    rental.Garage.Vehicle.VehicleType.Description = Convert.ToString(reader.Value);
                                break;

                        }
                    }

                    else if (reader.Name == "Rental")
                    {
                        rentals.Add(rental);
                        rental = null;
                    }
                }

                reader.Close(); 
                archivo.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return rentals;
        }
    }
}

