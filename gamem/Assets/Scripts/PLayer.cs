using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PLayer : MonoBehaviour
{
    public float speed=5f;
    public float jumppspeed=50f;
    private  float movement=0f;
    public static  Rigidbody2D ridgidbody;
    private Animator Animationrun,Animationjump;
    public static int score;
    public static int heath;
    public static Vector2 xy ;

    public Image image1, image2, image3, image4, image5;
    // Start is called before the first frame update
    public   PLayer()
    {

     
          
      
        //xy = GetComponent<Rigidbody2D>().position;
        // Update();

    }
    void Start()
    {
        image1.GetComponent<Image>();
        image2.GetComponent<Image>();
        image3.GetComponent<Image>();
        image4.GetComponent<Image>();
        image5.GetComponent<Image>();
        //Animationrun= gameObject.GetComponent<Animator>();
        //gameObject.GetComponent<Animator>().enabled = false;
        score = SaveData.Storescore;


        if (SaveData.StoreHealth == 0)
            SaveData.setheath();
        ridgidbody =GetComponent<Rigidbody2D>();
        xy=ridgidbody.position;
        heath = SaveData.StoreHealth;
        if(heath==1)
        {
            image2.gameObject.active = false;
            image3.gameObject.active = false;
            image4.gameObject.active = false;
            image5.gameObject.active = false;

        }
       else  if (heath == 2)
        {
            image5.gameObject.active = false;
            image3.gameObject.active = false;
            image4.gameObject.active = false;
         

        }
       else if (heath == 3)
        {
           
            image4.gameObject.active = false;
            image5.gameObject.active = false;

        }
        else if (heath == 4)
        {
         
            image5.gameObject.active = false;

        }
        //Debug.Log("Start");
        // Animation =GetComponent<Animator>();
        //if(SaveData.Storescore>0)
        //{
        //    ridgidbody.position = new Vector2(SaveData.x,SaveData.y);
        //}
       
    }
   void FixedUpdate()
    {
        //Debug.Log("Done");
        if(Input.GetKey(KeyCode.D))
        {
            // Debug.Log("Key");
            //gameObject.GetComponent<Animator>().enabled = true;
            ridgidbody.velocity = new Vector2(speed*5, ridgidbody.velocity.y);

        }
        //else
        //    gameObject.GetComponent<Animator>().enabled = false;
        if (Input.GetKey(KeyCode.A))
        {
           // Debug.Log("Key");
            ridgidbody.velocity = new Vector2(-speed*5, ridgidbody.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
          //  Debug.Log("Up");
            ridgidbody.velocity = new Vector2(ridgidbody.velocity.x, 10f);
        }
        Debug.Log(heath);
      if(Input.GetMouseButtonDown(0))
        {
            ridgidbody.velocity = new Vector2(ridgidbody.velocity.x, 10f);
        }
        if (Input.GetMouseButtonDown(1))
        {
            ridgidbody.velocity = new Vector2(speed * 5, ridgidbody.velocity.y);
        }
       





    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Pka");
    }


    public  static void setposition()
    {
        ridgidbody.transform.position = xy;
        ridgidbody.velocity = new Vector2(0, 0);
    }

   
}
