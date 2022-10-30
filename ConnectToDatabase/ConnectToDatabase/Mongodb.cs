using System;
using System.Collections;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Mongodb : Database
{

	public Mongodb()
	{
		Console.WriteLine("Mongodb created 😥");
	}

	public Mongodb(string name, int year) 
	{
		this.name = name;
		this.year = year;
	}

	public Mongodb(string name, int year, ArrayList data)
	{
		this.name = name;
		this.year = year;
		this.data = data;
	}

    public override string ToString()
    {
        return this.name+" "+this.year;
		foreach(string a in this.data)
		{
			Console.WriteLine(a);
		}
	}
}

