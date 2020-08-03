using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    List<GameObject> my_points;
    GameObject a;
    public GameObject map_point;
    public Button M_Button;


    int clicked = 0;
    // Start is called before the first frame update
    void Start()
    {
        my_points = new List<GameObject>();
        M_Button = GameObject.Find("Point").GetComponent<Button>();
        M_Button.onClick.RemoveAllListeners();
        M_Button.onClick.AddListener(()=>distance());
    }


    // Update is called once per frame
    void Update()
    {
        //creating points in mape
        if (Input.GetMouseButtonDown(0))
        {
            if (clicked < 5) {
                var screenPos = Input.mousePosition;
                screenPos.z = 1;
                var worldPos = this.GetComponent<Camera>().ScreenToWorldPoint(screenPos);
                my_points.Add(Instantiate(map_point, worldPos, Quaternion.identity));
               // Destroy(map_point, 3);
                clicked++;
                
            }
        }

        if (clicked == 5)
            my_points[4].GetComponent<Renderer>().material.color = Color.green;
    }

    public void distance()
    {
       
        double min_distance=double.MaxValue;
        int min_index=0;

        for (int i = 0; i< 4; i++)
        {
            double delta_x = my_points[i].transform.position.x - my_points[4].transform.position.x;
            double delta_y = my_points[i].transform.position.y - my_points[4].transform.position.y;
            double dist = Math.Sqrt(Math.Pow(delta_x, 2) + Math.Pow(delta_y, 2));
            if(dist < min_distance)
            {
                min_distance = dist;
                min_index = i;
            }
        }
        my_points[min_index].GetComponent<Renderer>().material.color = Color.blue;
    }
}
