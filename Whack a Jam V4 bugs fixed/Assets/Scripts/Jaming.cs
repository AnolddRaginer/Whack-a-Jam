using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jaming : MonoBehaviour
{
    public static int fruit;
    public static int water;
    public static int sugar;

    public GameObject sweet;
    public GameObject scrumptious;
    public GameObject sensational;
    public GameObject tingly;
    public GameObject delicious;
    public GameObject honey;

    int random;

    // Start is called before the first frame update
    void Start()
    {
        fruit = 0;
        water = 0;
        sugar = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (fruit >= 1 && water >=1 && sugar >= 1)//Combo
        {
            Scores.scoreAmount += 30;
            fruit--;//Decreases amount of each by one so it can check when all three have been gathered again
            water--;
            sugar--;
 
            random = Random.Range(0, 5);
            if (random == 0)
            {
                Instantiate(sweet);//on the cords of the prefab
                Destroy(sweet, 3);
            }
            else if (random == 1)
            {
                Instantiate(scrumptious);
                Destroy(scrumptious, 3);
            }
            else if (random == 2)
            {
                Instantiate(sensational);
                Destroy(sensational, 3);
            }
            else if (random == 3)
            {
                Instantiate(tingly);
                Destroy(tingly, 3);
            }
            else if (random == 4)
            {
                Instantiate(delicious);
                Destroy(delicious, 3);
            }
            else if (random == 5)
            {
                Instantiate(honey);
                Destroy(honey, 3);
            }
  
            //Destroy(word, 3);

        }
    }
}
