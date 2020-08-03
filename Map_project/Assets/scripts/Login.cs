using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Login : MonoBehaviour
{
    public GameObject username;
    public GameObject city;
    public Button M_Button;
    public GameObject errorIcon1;
    public GameObject errorIcon2;
    string Username="";
    string City="";
    // Start is called before the first frame update
    void Start()
    {
        M_Button = GameObject.Find("AcceptButton").GetComponent<Button>();
        M_Button.onClick.RemoveAllListeners();
        M_Button.onClick.AddListener(() => createFile());
    }


    // Update is called once per frame
    void Update()
    {


        Username = username.GetComponent<InputField>().text;
        City = city.GetComponent<InputField>().text;



    }

    void createFile()
    {
       
        StreamWriter writer = new StreamWriter("user.txt",false);

        writer.WriteLine(Username);
        writer.WriteLine(City);
        writer.Close();

        
    }
   public void LoadScene(string name)
    {
        if (Username == "" || City == "")
        {

            errorIcon1.SetActive(true);
            errorIcon2.SetActive(true);
        }

        else Application.LoadLevel(name);
    }
}
