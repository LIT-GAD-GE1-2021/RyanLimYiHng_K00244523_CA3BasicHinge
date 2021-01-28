using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * The LevelManager from the Week 6 Lecture
 */
public class LevelManager : MonoBehaviour 
{
    public TrapdoorScript trapdoor;

    public static LevelManager instance;

    private void Awake()
    {
        // set the instance property/variable to this object
        instance = this;
    }

    void Update()
    {

    }

    public void trapDoorFunction( string status )
    {
        if (status == "open")
        {
            trapdoor.SetHingeMotorSpeed(30);
        }
        else if (status == "close")
        {
            trapdoor.SetHingeMotorSpeed(-30);
        }
    }


}
