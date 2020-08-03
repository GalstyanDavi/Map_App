using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PersonalInfo : MonoBehaviour
{
    public Text name_text;
    public Text city_text;
    // Start is called before the first frame update
    void Start()
    {
        ReadString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ReadString()
    {
        string path = "user.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        name_text.text = reader.ReadLine();
        city_text.text = reader.ReadLine();

        reader.Close();
    }
}
