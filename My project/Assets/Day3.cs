using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day3 : MonoBehaviour
{
    string Heroname = "Mario";
    int Heropower = 15;
    string Enemyname = "Juda";
    int Enemypower = 20;
    int playerspeed = 30;
   
    
    // Start is called before the first frame update
    void Start()

    {
    if ( Heropower > Enemypower )
        {
            print("This chracter is stronger");
        }
    else
        {
            print("This character is weak");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void setspeed()
}
