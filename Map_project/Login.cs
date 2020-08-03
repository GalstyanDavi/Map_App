using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Login : MonoBehaviour
{
    public GameObject username;
    public GameObject city;
    string Username;
    string City;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
                city.GetComponent<InputField>().Select();
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (city.GetComponent<InputField>().isFocused)
                username.GetComponent<InputField>().Select();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {

        }
        Username = username.GetComponent<InputField>().text;
        City = city.GetComponent<InputField>().text;

        StreamWriter writer = new StreamWriter("Assets/user.txt", true);
        writer.WriteLine(Username);
        writer.WriteLine(City);
        writer.Close();
    }
    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }
}
