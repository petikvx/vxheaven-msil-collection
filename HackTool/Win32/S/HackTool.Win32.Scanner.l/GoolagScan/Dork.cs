using System;

namespace GoolagScan;

public class Dork : IComparable
{
	protected string theName;

	protected string theTitle;

	protected string theCategory;

	protected string theQuery;

	protected string theComment;

	public string Name
	{
		get
		{
			return theName;
		}
		set
		{
			theName = value;
		}
	}

	public string Query
	{
		get
		{
			return theQuery;
		}
		set
		{
			theQuery = value;
		}
	}

	public string Title
	{
		get
		{
			return theTitle;
		}
		set
		{
			theTitle = value;
		}
	}

	public string Category
	{
		get
		{
			return theCategory;
		}
		set
		{
			theCategory = value;
		}
	}

	public string Comment
	{
		get
		{
			return theComment;
		}
		set
		{
			theComment = value;
		}
	}

	public Dork()
	{
		theName = "";
		theTitle = "";
		theCategory = "";
		theQuery = "";
		theComment = "";
	}

	public int CompareTo(object d)
	{
		Dork dork = d as Dork;
		return theName.CompareTo(dork.Name);
	}
}
