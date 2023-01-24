/* Responsibility: To store the user name and password from the user and verify that he's authorized to open that jorunal. */

using System;
public class Login{

    public string _username;

    public string _password;

    public string _userNameInput;

    public string _passwordInput;

    public Array _usersList;

    public Boolean VerifyUserName(){
        return false;
    }

    public Boolean VerifyPassword(){
        return false;
    }

    public string InputUserName(){
        return null;
    }

    public string InputPassword(){
        return null;
    }
}