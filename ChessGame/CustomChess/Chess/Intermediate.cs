using System;
using System.Xml;

namespace CustomChess
{
	[Serializable]
	public class Intermediate
	{
		private Player wPlayer;       
		private Player bPlayer;      
		public Intermediate()
		{
		}
		public XmlNode LinkPlayerInfo(XmlDocument xmlDoc)
		{
			XmlElement xmlGame = xmlDoc.CreateElement("NewGame");
			xmlGame.AppendChild(Serializer.CreateNodeWithXmlValue(xmlDoc, "WhitePlayer", Serializer.XmlSerialize(typeof(Player), wPlayer)));
			xmlGame.AppendChild(Serializer.CreateNodeWithXmlValue(xmlDoc, "BlackPlayer", Serializer.XmlSerialize(typeof(Player), bPlayer)));
			return xmlGame;
		}

		public void SavePlayerInfo(XmlNode xmlGame)
		{
			XmlNode xmlPlayer = Serializer.GetFirstNodeByName(xmlGame, "WhitePlayer");
			wPlayer = (Player)Serializer.XmlDeserialize(typeof(Player), xmlPlayer.InnerXml);
			xmlPlayer = Serializer.GetFirstNodeByName(xmlGame, "BlackPlayer");
			bPlayer = (Player)Serializer.XmlDeserialize(typeof(Player), xmlPlayer.InnerXml);
		}
		public void SaveGame(string path)
		{
			try
			{
				XmlDocument gameXmlDocument = new XmlDocument();
				XmlNode gameXml = LinkPlayerInfo(gameXmlDocument);
				gameXmlDocument.AppendChild(gameXmlDocument.CreateXmlDeclaration("1.0", "utf-8", null));
				gameXmlDocument.AppendChild(gameXml);
				gameXmlDocument.Save(path);
				return;
			}
			catch (Exception) 
			{ 

			}
		}
	}
}
