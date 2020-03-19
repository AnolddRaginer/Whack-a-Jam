using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners3 : MonoBehaviour
{
    //Private variable
    private int rnd;
    private int rnd2;

    //Possible objects that can spawn
    public GameObject fruit;
    public GameObject rottenFruit;
    public GameObject water;
    public GameObject rottenWater;
    public GameObject sugar;
    public GameObject salt;

    //Spawn positions and height
    public GameObject Spawn1;
    public GameObject target1;
    public GameObject Spawn2;
    public GameObject target2;
    public GameObject Spawn3;
    public GameObject target3;
    

    public float timeTill;
    public int Max;
    public GameObject target;

    Movement Origin;

    // Start is called before the first frame update
    void Start()
    {
        Movement.Level2 = false;
        Movement.Level5 = false;
        timeTill = Random.Range(2f, 7f);
        target = GameObject.Find("Target");
    }

    // Update is called once per frame
    void Update()
    {
        //if statement that checks if the spawner is active, rnd pick of spawner and then it picks object to spawn. do while loop incase spawner is active
        timeTill -= Time.deltaTime;
        if (timeTill <= 0)
        {
            rnd = Random.Range(0, 6);
            rnd2 = Random.Range(0, 3);
            if (rnd == 0)
            {
                if (rnd2 == 0)
                {
                    //transform.position = Spawn1.transform.position;
                    Instantiate(fruit, Spawn1.transform.position, fruit.transform.rotation);

                    target.transform.position = target1.transform.position;
                    // Origin.transform.position = Spawn1.transform.position;
                    Debug.Log("6");
                }
                if (rnd2 == 1)
                {
                    //transform.position = Spawn2.transform.position;
                    Instantiate(fruit, Spawn2.transform.position, fruit.transform.rotation);
                    target.transform.position = target2.transform.position;
                    //Origin.transform.position = Spawn2.transform.position;
                    Debug.Log("6");
                }
                if (rnd2 == 2)
                {
                    // transform.position = Spawn3.transform.position;
                    Instantiate(fruit, Spawn3.transform.position, fruit.transform.rotation);
                    target.transform.position = target3.transform.position;
                    //Origin.transform.position = Spawn3.transform.position;
                    Debug.Log("6");
                }
               
            }
            if (rnd == 1)
            {
                if (rnd2 == 0)
                {
                    // transform.position = Spawn1.transform.position;
                    Instantiate(rottenFruit, Spawn1.transform.position, rottenFruit.transform.rotation);
                    target.transform.position = target1.transform.position;
                    //Origin.transform.position = Spawn1.transform.position;
                }
                if (rnd2 == 1)
                {
                    //transform.position = Spawn2.transform.position;
                    Instantiate(rottenFruit, Spawn2.transform.position, rottenFruit.transform.rotation);
                    target.transform.position = target2.transform.position;
                }
                if (rnd2 == 2)
                {
                    //transform.position = Spawn3.transform.position;
                    Instantiate(rottenFruit, Spawn3.transform.position, rottenFruit.transform.rotation);
                    target.transform.position = target3.transform.position;
                }
                
            }
            if (rnd == 2)
            {
                if (rnd2 == 0)
                {
                    //  transform.position = Spawn1.transform.position;
                    Instantiate(water, Spawn1.transform.position, water.transform.rotation);
                    target.transform.position = target1.transform.position;
                    // Origin.transform.position = Spawn1.transform.position;
                }
                if (rnd2 == 1)
                {
                    //  transform.position = Spawn2.transform.position;
                    Instantiate(water, Spawn2.transform.position, water.transform.rotation);
                    target.transform.position = target2.transform.position;
                }
                if (rnd2 == 2)
                {
                    // transform.position = Spawn3.transform.position;
                    Instantiate(water, Spawn3.transform.position, water.transform.rotation);
                    target.transform.position = target3.transform.position;
                }
                
            }
            if (rnd == 3)
            {
                if (rnd2 == 0)
                {
                    // transform.position = Spawn1.transform.position;
                    Instantiate(rottenWater, Spawn1.transform.position, rottenWater.transform.rotation);
                    target.transform.position = target1.transform.position;
                    // Origin.transform.position = Spawn1.transform.position;
                }
                if (rnd2 == 1)
                {
                    // transform.position = Spawn2.transform.position;
                    Instantiate(rottenWater, Spawn2.transform.position, rottenWater.transform.rotation);
                    target.transform.position = target2.transform.position;
                }
                if (rnd2 == 2)
                {
                    //  transform.position = Spawn3.transform.position;
                    Instantiate(rottenWater, Spawn3.transform.position, rottenWater.transform.rotation);
                    target.transform.position = target3.transform.position;
                }
                
            }
            if (rnd == 4)
            {
                if (rnd2 == 0)
                {
                    // transform.position = Spawn1.transform.position;
                    Instantiate(sugar, Spawn1.transform.position, sugar.transform.rotation);
                    target.transform.position = target1.transform.position;
                    //Origin.transform.position = Spawn1.transform.position;
                }
                if (rnd2 == 1)
                {
                    //transform.position = Spawn2.transform.position;
                    Instantiate(sugar, Spawn2.transform.position, sugar.transform.rotation);
                    target.transform.position = target2.transform.position;
                }
                if (rnd2 == 2)
                {
                    // transform.position = Spawn3.transform.position;
                    Instantiate(sugar, Spawn3.transform.position, sugar.transform.rotation);
                    target.transform.position = target3.transform.position;
                }
                
            }
            if (rnd == 5)
            {
                if (rnd2 == 0)
                {
                    // transform.position = Spawn1.transform.position;
                    Instantiate(salt, Spawn1.transform.position, salt.transform.rotation);
                    target.transform.position = target1.transform.position;
                    // Origin.transform.position = Spawn1.transform.position;
                }
                if (rnd2 == 1)
                {
                    // transform.position = Spawn2.transform.position;
                    Instantiate(salt, Spawn2.transform.position, salt.transform.rotation);
                    target.transform.position = target2.transform.position;
                }
                if (rnd2 == 2)
                {
                    // transform.position = Spawn3.transform.position;
                    Instantiate(salt, Spawn3.transform.position, salt.transform.rotation);
                    target.transform.position = target3.transform.position;
                }
               
            }
            timeTill = Random.Range(1.5f, 2f);
        }
    }
}
