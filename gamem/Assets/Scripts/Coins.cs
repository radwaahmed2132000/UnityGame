using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityEngine.SceneManagement;
public class Coins : MonoBehaviour
{


    public Text myscore;
    private int scorenumber;
    // Start is called before the first frame update
    void Start()
    {

        myscore.text = "X" + PLayer.score;
  
     
    }
 
    // Update is called once per frame
    void Update()
    {


    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        PLayer.score += 1;
        SaveData.Storescore = PLayer.score;
       Destroy(gameObject);
            myscore.text = "X" + PLayer.score;
        if (PLayer.score == 8)
            SceneManager.LoadScene("Quiz1");
        if (PLayer.score == 12)
            SceneManager.LoadScene("Quiz2");
        if (PLayer.score == 23)
            SceneManager.LoadScene("Quiz3");


    }
}
