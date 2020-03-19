using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 3;
    public static bool Level2;
    public static bool Level5;
    bool first = true;
    bool second = false;
    bool third = false;
    bool fourth = false;
    bool fifth = false;
    bool sixth = false;
    bool seventh = false;
    bool eitgthe = false;
    bool ninth = false;
    bool tenth = false;
    bool elenvth = false;
    bool twelve = false;
    bool thriteen = false;
    bool fourteen = false;
    bool end = false;

    public GameObject target;

    public Vector3 origin;
    public static Vector3 destination;
    public Camera camera;
    
    // Use this for initialization
    void Start()
    {
        origin = transform.position;
        target = GameObject.Find("Target");
        coord.t2 = GameObject.Find("Target2");
        sound.sndMan.PlayJumpSound();
    }
    void Destroygameobjct() {
        Destroy(gameObject);
    }
    
    void Update()
    {
        if (Level2 == false && Level5 == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

            if (transform.position == target.transform.position && Level2 == false)
            {
                Debug.Log("moving home");
                target.transform.position = origin;
            }
            
        }
        else if (Level2 == true && Level5 == false)
        {
            if (first == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
                if (transform.position == target.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, coord.t2.transform.position, speed * Time.deltaTime);
                    Debug.Log("moving to 2");
                    second = true;
                    first = false;
                }
            }
            if (second == true)
            {
                //first = false;
                transform.position = Vector3.MoveTowards(transform.position, coord.t2.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t2.transform.position)
                {
                    second = false;
                    third = true;
                }
                
            }
            if (third == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t3.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t3.transform.position)
                {
                    third = false;
                    fourth = true;
                }
            }
            if (fourth == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t4.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t4.transform.position)
                {
                    fourth = false;
                    fifth = true;
                }
            }
            if (fifth == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t5.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t5.transform.position)
                {
                    fifth = false;
                    sixth = true;
                }
            }
            if (sixth == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t6.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t6.transform.position)
                {
                    sixth = false;
                    seventh = true;
                }
            }
            if (seventh == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t7.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t7.transform.position)
                {
                    seventh = false;
                    eitgthe = true;
                }
            }
            if (eitgthe == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t8.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t8.transform.position)
                {
                    eitgthe = false;
                    ninth = true;
                }
            }
            if (ninth == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t9.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t9.transform.position)
                {
                    ninth = false;
                    tenth = true;
                }
            }
            if (tenth == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t10.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t10.transform.position)
                {
                    tenth = false;
                    elenvth = true;
                }
            }
            if (elenvth == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t11.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t11.transform.position)
                {
                    elenvth = false;
                    twelve = true;
                }
            }
            if (twelve == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t12.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t12.transform.position)
                {
                    twelve = false;
                    thriteen = true;
                }
            }
            if (thriteen == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t13.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t13.transform.position)
                {
                    thriteen = false;
                    fourteen = true;
                }
            }
            if (fourteen == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t14.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t14.transform.position)
                {
                    fourteen = false;
                    end = true;
                }
            }
            if (end == true)
            {
                Destroygameobjct();
            }

        }
        else if (Level5 == true && Level2 == false)
        {
            if (first == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
                if (transform.position == target.transform.position)
                {
                    //transform.position = Vector3.MoveTowards(transform.position, coord.t2.transform.position, speed * Time.deltaTime);
                    Debug.Log("moving to 2");
                    second = true;
                    first = false;
                }
            }
            if (second == true)
            {
                //first = false;
                transform.position = Vector3.MoveTowards(transform.position, coord.t2.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t2.transform.position)
                {
                    second = false;
                    third = true;
                }

            }
            if (third == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t3.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t3.transform.position)
                {
                    third = false;
                    fourth = true;
                }
            }
            if (fourth == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t4.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t4.transform.position)
                {
                    fourth = false;
                    fifth = true;
                }
            }
            if (fifth == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t5.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t5.transform.position)
                {
                    fifth = false;
                    sixth = true;
                }
            }
            if (sixth == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t6.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t6.transform.position)
                {
                    sixth = false;
                    seventh = true;
                }
            }
            if (seventh == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t7.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t7.transform.position)
                {
                    seventh = false;
                    eitgthe = true;
                }
            }
            if (eitgthe == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t8.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t8.transform.position)
                {
                    eitgthe = false;
                    ninth = true;
                }
            }
            if (ninth == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, coord.t9.transform.position, speed * Time.deltaTime);
                if (transform.position == coord.t9.transform.position)
                {
                    ninth = false;
                    end = true;
                }
            }
            if (end == true)
            {
                Destroygameobjct();
            }
        }

    }
}
        

    
   

