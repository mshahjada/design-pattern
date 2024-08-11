using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Adapter
{
    internal class XMLAdapter : IXmlClient
    {
        public XElement ConvertJsonToXml()
        {
            var studentJson = new JsonDataProvider().GetStudentData();

            JArray jArray = JsonConvert.DeserializeObject<JArray>(studentJson);

            var xml = new XElement("root",
                new XElement("students",
                    from item in jArray
                    select new XElement("student",
                        new XElement("Name", item["Name"].ToString() ?? ""),
                        new XElement("Age", item["Age"].ToString() ?? ""),
                        new XElement("Id", item["Id"].ToString() ?? "")
                        )
                    ));

            return xml;

        }
    }
}
