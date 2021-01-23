using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class  Power : MonoBehaviour
{

    private int scorenumber;
    public Image image1, image2, image3, image4, image5;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Trigger");


        image1.GetComponent<Image>();
        image2.GetComponent<Image>();
        image3.GetComponent<Image>();
        image4.GetComponent<Image>();
        image5.GetComponent<Image>();


    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void OnTriggerEnter2D(Collider2D other)
    {
    

        PLayer.heath--;
        Debug.Log(PLayer.heath);
        SaveData.StoreHealth = PLayer.heath;
     
            //Destroy(gameObject);
       
        PLayer.setposition();
        Debug.Log(SaveData.StoreHealth);
        if (PLayer.heath <= 0)
        {
            SaveData.StoreHealth = 0;
            SaveData.Storescore = 0;
            image1.gameObject.active = false;
            image2.gameObject.active = false;
            image3.gameObject.active = false;
            image4.gameObject.active = false;
            image5.gameObject.active = false;
            SceneManager.LoadScene("Main Menu");

        }
          
        //PLayer.xy = new Vector2(-277.88f, -27.4f);
        //PLayer.ridgidbody.transform.position = PLayer.xy;
        //PLayer.ridgidbody.velocity=new Vector2(0,0);
        //Debug.Log(PLayer.ridgidbody.position.x);
        if (PLayer.heath == 1)
        {
            image2.gameObject.active = false;
            image3.gameObject.active = false;
            image4.gameObject.active = false;
            image5.gameObject.active = false;

        }
        else if (PLayer.heath == 2)
        {
            
            image3.gameObject.active = false;
            image4.gameObject.active = false;
            image5.gameObject.active = false;

        }
        else if (PLayer.heath == 3)
        {

            image4.gameObject.active = false;
            image5.gameObject.active = false;

        }
        else if (PLayer.heath == 4)
        {

            image5.gameObject.active = false;

        }


    }
}
