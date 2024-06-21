using System;

public class Account
{
	private string username;
	private string password;
	private string type;
	private string firstName;
	private string lastName;
	private string dateOfBirth;
	public Account()
	{
		
	}

    public string Username { get => username; set => username = value; }
    public string Password { get => password; set => password = value; }
    public string Type { get => type; set => type = value; }
    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
}
