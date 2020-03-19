using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Destruction : MonoBehaviour
{
    public Vector3 origin; //Variable to store spawn position
    
    Collider2D col;

    bool death; // Variable for detect "death" of gameobject
    public int points;//Variable to store how much points are awarded for picking a valid option

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
        origin = transform.position; 
        

        death = false;
        DestroyObjectDelayed();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != origin)//checks if object is back in spawn position
        {
            death = true;
        }
        if ((transform.position == origin) && (death = true))//If it is in the spawn pos it destory the gameobject
        {
            DestroyGameObject();
        }
        if (Input.touchCount > 0) //Check if the object has been touched 
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);//Finds touch position
            RaycastHit hit;
            if(touch.phase == TouchPhase.Began)
            {
                Collider2D touched = Physics2D.OverlapPoint(touchPosition);
                if(col == touched)
                {
                    Points();
                }
            }            
        }
    }
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
    void DestroyObjectDelayed()
    {
        Destroy(gameObject, 5);
    }
    void Points()
    {
        Scores.scoreAmount += points;//Increases players score
        Debug.Log(points);//Check points for dev
        Destroy(gameObject);//Destorys gameobject after being touched
        
        particles.straw_down = true;//Makes particles play

        //If statments below check if its a valid object worth points
        if (gameObject.CompareTag("Fruit"))
        {
            soundsplat.sndMan.PlaySplatSound();//Plays splt sound
            Jaming.fruit++;//Adds Towards friut score - possible discounted feature??
        }
        if (gameObject.CompareTag("Water"))
        {
            Jaming.water++;//Adds Towards water score - possible discounted feature??
        }
        if (gameObject.CompareTag("Sugar"))
        {
            Jaming.sugar++;//Adds Towards sugar score - possible discounted feature??
        }
    }
}
