using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using static TennisScheduleMvc.Models.EventModel;

namespace TennisScheduleMvc.Models
{
    public class TennisScheduleModel
    {
        public Event ReadXml()
        {
            XmlSerializer reader = new XmlSerializer(typeof(Event));
            var fileName = Path.Combine(HttpContext.Current.ApplicationInstance.
                Server.MapPath("~/App_Data"),
                "TennisSchedule.xml");
            StreamReader file = new StreamReader(fileName);
            Event tennisEvent = (Event)reader.Deserialize(file);
            file.Close();
            return tennisEvent;
        }
    }
}