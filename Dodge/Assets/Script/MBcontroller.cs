using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class MBcontroller : PlayerController
{
    public GameObject Rbutton;
    public Button Upbutton;
    public Button Downbutton;
    public Button Leftbutton;
    public Button Rightbutton;

    Vector3 moveVelocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Upbutton)
        {
            moveVelocity = new Vector3(0, 0, speed);
        }

        if(Downbutton)
        {
            moveVelocity = new Vector3(0, 0, -speed);
        }

        if(Leftbutton)
        {
            moveVelocity = new Vector3(speed, 0, 0);
        }

        if(Rightbutton)
        {
            moveVelocity = new Vector3(-speed, 0, 0);
        }
    }
}
