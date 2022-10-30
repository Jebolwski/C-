using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class User
{
	public string username { get; set; }
	public string email { get; set; }
	public User(string username,string email)
	{
		this.username = username;
		this.email = email;
	}
	public User() { 
	}
}
