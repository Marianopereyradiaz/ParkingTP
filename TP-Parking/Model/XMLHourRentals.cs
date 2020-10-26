using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace TP_Parking.Model
{
    class XMLHourRentals
    { 
          private string fileRoute = @"C:\ParkingFiles\hourRentals.xml";

    public void GenerateXML(List<HourRental> hourRentals)
    {
        try
        {

            XmlTextWriter writer = new XmlTextWriter(fileRoute, null);


            writer.Formatting = Formatting.Indented;


            writer.WriteStartDocument();


            writer.WriteStartElement("HourRentals");


            foreach (HourRental hourRental in hourRentals)
            {

                writer.WriteStartElement("HourRental");


                writer.WriteElementString("DateTime", hourRental.Date.ToString());
                writer.WriteElementString("Start", hourRental.Start.ToString());
                writer.WriteElementString("Value", hourRental.Value.ToString());
                writer.WriteElementString("Finish", hourRental.Finish.ToString());


                writer.WriteStartElement("Garage");
                writer.WriteElementString("Number", hourRental.Garage.Number.ToString());
                writer.WriteElementString("State", hourRental.Garage.State.ToString());


                writer.WriteStartElement("Vehicle");
                writer.WriteElementString("Brand", hourRental.Garage.Vehicle.Brand);
                writer.WriteElementString("Domain", hourRental.Garage.Vehicle.Domain);
                writer.WriteElementString("Model", hourRental.Garage.Vehicle.Model);

                writer.WriteStartElement("VehicleType");
                writer.WriteElementString("Code", hourRental.Garage.Vehicle.VehicleType.Code.ToString());
                writer.WriteElementString("Description", hourRental.Garage.Vehicle.VehicleType.Description.ToString());

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

    public List<HourRental> ReturnRentals()
    {
        List<HourRental> HourRentals = new List<HourRental>();

        try
        {

            FileStream archivo = new FileStream(fileRoute, FileMode.Open, FileAccess.Read);


            XmlTextReader reader = new XmlTextReader(archivo);


            HourRental hourRental = null;
            Garage garage = null;
            Vehicle vehicle = null;
            VehicleType vehicleType = null;

            while (reader.Read())
            {

                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "HourRentals":
                            break;

                        case "HourRental":
                            hourRental = new HourRental();
                            break;

                        case "Garage":
                                hourRental.Garage = new Garage();
                            break;

                        case "Vehicle":
                                hourRental.Garage.Vehicle = new Vehicle();
                            break;

                        case "VehicleType":
                                hourRental.Garage.Vehicle.VehicleType = new VehicleType();
                            break;

                        case "DateTime":
                            if (reader.Read())
                                    hourRental.Date = Convert.ToDateTime(reader.Value);
                            break;

                        case "Start":
                            if (reader.Read())
                                    hourRental.Start = Convert.ToDateTime(reader.Value);
                            break;

                        case "Finish":
                            if (reader.Read())
                                    hourRental.Finish = Convert.ToDateTime(reader.Value);
                            break;

                        case "Value":
                            if (reader.Read())
                                    hourRental.Value = Convert.ToDouble(reader.Value);
                            break;

                        case "Number":
                            if (reader.Read())
                                    hourRental.Garage.Number = Convert.ToInt32(reader.Value);
                            break;

                        case "State":
                            if (reader.Read())
                                    hourRental.Garage.State = Convert.ToBoolean(reader.Value);
                            break;

                        case "Brand":
                            if (reader.Read())
                                    hourRental.Garage.Vehicle.Brand = reader.Value;
                            break;

                        case "Domain":
                            if (reader.Read())
                                    hourRental.Garage.Vehicle.Domain = reader.Value;
                            break;

                        case "Model":
                            if (reader.Read())
                                    hourRental.Garage.Vehicle.Model = reader.Value;
                            break;

                        case "Code":
                            if (reader.Read())
                                    hourRental.Garage.Vehicle.VehicleType.Code = Convert.ToInt32(reader.Value);
                            break;

                        default:
                            if (reader.Read())
                                    hourRental.Garage.Vehicle.VehicleType.Description = Convert.ToString(reader.Value);
                            break;

                    }
                }

                else if (reader.Name == "HourRental")
                {
                    HourRentals.Add(hourRental);
                        hourRental = null;
                }
            }

            reader.Close();
            archivo.Close();
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return HourRentals;
    }
}
}

