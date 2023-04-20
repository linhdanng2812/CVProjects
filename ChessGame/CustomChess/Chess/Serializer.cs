using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CustomChess
{
    internal class Serializer
    {
        internal static object XmlDeserialize(Type type, string xml)
        {
            XmlSerializer serializer = new XmlSerializer(type);
            StringReader stringReader = new StringReader(xml);
            object obj = serializer.Deserialize(stringReader);
            return obj;
        }
        internal static XmlNode GetFirstNodeByName(XmlNode xmlParentNode, string name)
        {
            XmlNodeList nodeList = (xmlParentNode as XmlElement).GetElementsByTagName(name);

            if (nodeList != null)
                return nodeList[0];
            else
                return null;
        }
        internal static string GetNodeText(XmlNode node, string name)
        {
            if (node == null)
                return string.Empty;

            XmlElement xmlElement = node as XmlElement;
            if (xmlElement == null)
                return string.Empty;
            XmlNodeList nodeList = xmlElement.GetElementsByTagName(name);

            if (nodeList != null && nodeList.Count > 0)
            {
                return nodeList[0].InnerText;
            }
            return string.Empty;
        }
        internal static string GetNodeXml(XmlNode node, string name)
        {
            return GetNodeXml(node, name, "");
        }
        internal static string GetNodeXml(XmlNode node, string name, string namespaceUri)
        {
            if (node == null)
                return string.Empty;

            XmlElement xmlElement = node as XmlElement;
            if (xmlElement == null)
                return string.Empty;

            XmlNodeList nodeList;

            if (string.IsNullOrEmpty(namespaceUri))
                nodeList = xmlElement.GetElementsByTagName(name);
            else
                nodeList = xmlElement.GetElementsByTagName(name, namespaceUri);

            if (nodeList != null && nodeList.Count > 0)
            {
                return nodeList[0].InnerXml;
            }

            return string.Empty;
        }

        internal static XmlNode CreateNodeWithValue(XmlDocument xmlDoc, string nodeName, string NodeValue)
        {
            XmlNode xmlNode = xmlDoc.CreateElement(nodeName);
            xmlNode.InnerText = NodeValue;
            return xmlNode;
        }

        internal static XmlNode CreateNodeWithXmlValue(XmlDocument xmlDoc, string nodeName, string NodeValue)
        {
            XmlNode xmlNode = xmlDoc.CreateElement(nodeName);
            xmlNode.InnerXml = NodeValue;
            return xmlNode;
        }
        
        internal static string XmlSerialize(Type type, Object obj)
        {
            XmlSerializer serializer = new XmlSerializer(type);
            StringWriter stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, obj);
            return stringWriter.ToString().Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "").Replace("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"", "").Trim();
        }

    }
}
