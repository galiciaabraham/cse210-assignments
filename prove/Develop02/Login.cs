/* Responsibility: To store the PIN from the user and verify that he's authorized to open the journal. */

using System;
public class Login{

    public string _pIN;

    public string _pINInput;

    public Boolean _pass;

    public List<string> _ListOfPINs = new List<string>{"1234", "4321", "3412", "9999"};


    public void GetInputPIN(){
        Console.Write("Please enter your PIN: ");
        _pINInput = Console.ReadLine();
    }
    public void VerifyPIN(){
        GetInputPIN();
        if (_ListOfPINs.Contains(_pINInput)){
            _pass = true;
        }
        else{
            _pass = false;
        }
    }


}