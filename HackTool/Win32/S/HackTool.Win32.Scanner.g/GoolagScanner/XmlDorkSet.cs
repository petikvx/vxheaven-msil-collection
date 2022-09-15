using System;
using System.Collections;
using System.IO;
using System.Xml;

namespace GoolagScanner;

internal class XmlDorkSet
{
	protected XmlDocument xmldoc;

	protected ArrayList dorkcollection;

	protected Categories categorycollection;

	private int dorksCount;

	public int Count => dorksCount;

	public XmlDorkSet(ArrayList dorklist, Categories categories)
	{
		dorksCount = 0;
		dorkcollection = dorklist;
		categorycollection = categories;
	}

	protected XmlDorkSet()
	{
		dorksCount = 0;
	}

	protected XmlDorkSet(ArrayList dorklist)
	{
		dorkcollection = dorklist;
		dorksCount = 0;
	}

	public void setDorkList(ArrayList dorklist)
	{
		dorkcollection = dorklist;
	}

	public void setCategoriesContainer(Categories categories)
	{
		categorycollection = categories;
	}

	public int Open(string filename)
	{
		if (File.Exists(filename))
		{
			xmldoc = new XmlDocument();
			try
			{
				xmldoc.Load(filename);
			}
			catch (XmlException)
			{
				throw;
			}
			catch (Exception)
			{
				throw;
			}
			XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
			xmlReaderSettings.ConformanceLevel = ConformanceLevel.Auto;
			xmlReaderSettings.IgnoreWhitespace = true;
			xmlReaderSettings.IgnoreComments = true;
			XmlNodeReader reader = new XmlNodeReader(xmldoc);
			XmlReader xmlReader = XmlReader.Create(reader, xmlReaderSettings);
			Dork dork = null;
			while (xmlReader.Read())
			{
				if (xmlReader.NodeType != XmlNodeType.Element)
				{
					continue;
				}
				if (xmlReader.Name == "CategoryItem")
				{
					xmlReader.Read();
					categorycollection.Add(xmlReader.Value);
				}
				if (xmlReader.Name == "Dork")
				{
					dork = new Dork();
					xmlReader.Read();
					dork.Name = xmlReader.Value;
				}
				if (xmlReader.Name == "Title")
				{
					xmlReader.Read();
					dork.Title = xmlReader.Value;
				}
				if (xmlReader.Name == "Category")
				{
					xmlReader.Read();
					dork.Category = xmlReader.Value;
				}
				if (xmlReader.Name == "Query")
				{
					xmlReader.Read();
					dork.Query = xmlReader.Value;
				}
				if (xmlReader.Name == "Comment")
				{
					xmlReader.Read();
					dork.Comment = xmlReader.Value;
					if (string.IsNullOrEmpty(dork.Title))
					{
						dork.Title = dork.Name;
					}
					dorkcollection.Add(dork);
					dorksCount++;
				}
			}
			return 0;
		}
		throw new FileNotFoundException();
	}

	protected int getDorksCount()
	{
		return dorksCount;
	}
}
