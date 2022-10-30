using System;
using System.Collections;

/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class  Database
{
	public string name { get; set; }
	public int year { get; set; }

	public ArrayList data { get; set; }
	public Database()
	{
	}

	public Database(string name, int year)
	{
		this.name = name;
		this.year = year;
	}

	public Database(string name, int year, ArrayList data)
	{
		this.name = name;
		this.year = year;
		this.data = data;
	}
}
