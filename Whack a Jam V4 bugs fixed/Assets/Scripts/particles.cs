using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles : MonoBehaviour
{
    public Animator Strawberry;
    public static bool straw_down;

    // Start is called before the first frame update
    void Start()
    {
        straw_down = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (straw_down == true)//Checks if particles should be running
        {
            red_part();
            Debug.Log("strawberry has gone");//Checks if this statement has done through - dev
        }
    }
    void red_part()//Runs particles
    {
        Strawberry.SetBool("gone", true);//Event to start particles
    }
}
