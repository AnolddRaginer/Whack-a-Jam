using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coord : MonoBehaviour
{
    public static GameObject t2;
    public static GameObject t3;
    public static GameObject t4;
    public static GameObject t5;
    public static GameObject t6;
    public static GameObject t7;
    public static GameObject t8;
    public static GameObject t9;
    public static GameObject t10;
    public static GameObject t11;
    public static GameObject t12;
    public static GameObject t13;
    public static GameObject t14;

    public static Vector3 target2;
    public static Vector3 target3;
    public static Vector3 target4;
    public static Vector3 target5;
    public static Vector3 target6;
    public static Vector3 target7;
    public static Vector3 target8;
    public static Vector3 target9; 
    public static Vector3 target10;
    public static Vector3 target11;
    public static Vector3 target12;
    public static Vector3 target13;
    public static Vector3 target14;

    // Start is called before the first frame update
    void Start()
    {
        t2 = GameObject.Find("Target2");
        t3 = GameObject.Find("Target3");
        t4 = GameObject.Find("Target4");
        t5 = GameObject.Find("Target5");
        t6 = GameObject.Find("Target6");
        t7 = GameObject.Find("Target7");
        t8 = GameObject.Find("Target8");
        t9 = GameObject.Find("Target9");
        t10 = GameObject.Find("Target10");
        t11 = GameObject.Find("Target11");
        t12 = GameObject.Find("Target12");
        t13 = GameObject.Find("Target13");
        t14 = GameObject.Find("Target14");

        target2 = t2.transform.position;
        target3 = t3.transform.position;
        target4 = t4.transform.position;
        target5 = t5.transform.position;
        target6 = t6.transform.position;
        target7 = t7.transform.position;
        target8 = t8.transform.position;
        target9 = t9.transform.position;
        target10 = t10.transform.position;
        target11 = t11.transform.position;
        target12 = t12.transform.position;
        target13 = t13.transform.position;
        target14 = t14.transform.position;

        //t2 = GameObject.Find("Target2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
