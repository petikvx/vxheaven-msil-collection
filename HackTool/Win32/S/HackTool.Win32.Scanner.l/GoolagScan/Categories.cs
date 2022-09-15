using System.Collections.Generic;

namespace GoolagScan;

public class Categories
{
	private string[] cats = new string[14]
	{
		"Advisories and Vulnerabilities", "Error Messages", "Files containing juicy info", "Files containing passwords", "Files containing usernames", "Footholds", "Pages containing login portals", "Pages containing network or vulnerability data", "Sensitive Directories", "Sensitive Online Shopping Info",
		"Various Online Devices", "Vulnerable Files", "Vulnerable Servers", "Web Server Detection"
	};

	private List<Category> l_categories;

	public int Count => l_categories.Count;

	protected Categories(bool usePreset)
	{
		l_categories = new List<Category>();
		if (usePreset)
		{
			for (int i = 0; i < cats.Length; i++)
			{
				Category item = new Category
				{
					Text = cats[i],
					Node = null
				};
				l_categories.Add(item);
			}
		}
	}

	public Categories()
	{
		l_categories = new List<Category>();
	}

	public void Add(string catName)
	{
		Category category = new Category();
		category.Text = catName;
		category.Node = null;
		l_categories.Add(category);
	}

	public Category getCategoryByIndex(int i)
	{
		return l_categories[i];
	}

	public IEnumerator<Category> GetEnumerator()
	{
		for (int i = 0; i < l_categories.Count; i++)
		{
			yield return l_categories[i];
		}
	}
}
