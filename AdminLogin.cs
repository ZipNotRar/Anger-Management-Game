using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AdminLogin : MonoBehaviour
{

    public InputField userNameField;
    public InputField passwordField;

    public Button loginButton;

    public Text loginFail;

    void Start()
    {
        //Subscribe to onClick event
        loginButton.onClick.AddListener(adminDetails);
        loginFail.text = "";
    }

    Dictionary<int, string> staffDetails = new Dictionary<int, string>
    {
        {101,"femi1998" },
        {102,"kwaks1999" },
        {103,"eman1999" }
    };

    public void adminDetails()
    {
        //Get Username from Input then convert it to int
        int userName = Convert.ToInt32(userNameField.text);
        //Get Password from Input 
        string password = passwordField.text;

        string foundPassword;
        if (staffDetails.TryGetValue(userName, out foundPassword) && (foundPassword == password))
        {
            SceneManager.LoadScene("TherapistScene");
        }
        else
        {
            loginFail.text = "Login Failed";

        }
    }
}