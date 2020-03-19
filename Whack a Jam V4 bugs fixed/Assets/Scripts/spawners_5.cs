using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawners_5 : MonoBehaviour
{
    private int rnd;
    private int rnd2;

    //Possible objects that can spawn
    public GameObject fruit;
    public GameObject rottenFruit;
    public GameObject water;
    public GameObject rottenWater;
    public GameObject sugar;
    public GameObject salt;

    //
    public GameObject Spawn1;
    public GameObject target1;
    public float timeTill;
    public int Max;
    public GameObject target;

    Movement Origin;
    // Start is called before the first frame update
    void Start()
    {
        Movement.Level5 = true;
        Movement.Level2 = false;
        timeTill = Random.Range(2f, 7f);
        target = GameObject.Find("Target");
    }

    // Update is called once per frame
    void Update()
    {
        timeTill -= Time.deltaTime;
        if (timeTill <= 0)
        {
            rnd = Random.Range(0, 6);
            if (rnd == 0)
            {

                //transform.position = Spawn1.transform.position;
                Instantiate(fruit, Spawn1.transform.position, fruit.transform.rotation);

                //target.transform.position = target1.transform.position;
                // Origin.transform.position = Spawn1.transform.position;
                Debug.Log("6");

            }
            if (rnd == 1)
            {

                // transform.position = Spawn1.transform.position;
                Instantiate(rottenFruit, Spawn1.transform.position, rottenFruit.transform.rotation);
                //target.transform.position = target1.transform.position;
                //Origin.transform.position = Spawn1.transform.position;

            }
            if (rnd == 2)
            {

                //  transform.position = Spawn1.transform.position;
                Instantiate(water, Spawn1.transform.position, water.transform.rotation);
                //target.transform.position = target1.transform.position;
                // Origin.transform.position = Spawn1.transform.position;

            }
            if (rnd == 3)
            {

                // transform.position = Spawn1.transform.position;
                Instantiate(rottenWater, Spawn1.transform.position, rottenWater.transform.rotation);
                //target.transform.position = target1.transform.position;
                // Origin.transform.position = Spawn1.transform.position;

            }
            if (rnd == 4)
            {

                // transform.position = Spawn1.transform.position;
                Instantiate(sugar, Spawn1.transform.position, sugar.transform.rotation);
                //target.transform.position = target1.transform.position;
                //Origin.transform.position = Spawn1.transform.position;

            }
            if (rnd == 5)
            {

                // transform.position = Spawn1.transform.position;
                Instantiate(salt, Spawn1.transform.position, salt.transform.rotation);
                // target.transform.position = target1.transform.position;
                // Origin.transform.position = Spawn1.transform.position;

            }
            timeTill = Random.Range(1f, 2f);
        }
    }
    }
