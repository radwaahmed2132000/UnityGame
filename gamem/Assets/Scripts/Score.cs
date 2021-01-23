using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text myscore;
    private int scorenumber;
    // Start is called before the first frame update
    void Start()
    {
      
        
        scorenumber = 0;
        myscore.text ="Score :"+scorenumber;
    }
    void OnTriggerEnter2D(Collider2D MyCoin)
    {
        if(MyCoin.tag=="MyCoin")
        {

        }
     
        Destroy(gameObject);
    }
    // Update is called once per frame

}
