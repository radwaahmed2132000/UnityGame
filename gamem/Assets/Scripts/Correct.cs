using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Correct : MonoBehaviour
{

    public Button button;
    public Button button2;
    public Button button3;

  
    // Start is called before the first frame update
    void Start()
    {
   
        button.GetComponent<Button>();
        button2.GetComponent<Button>();
        button3.GetComponent<Button>();
        button3.gameObject.active = false;
        button.onClick.AddListener(ontask);
        button2.onClick.AddListener(ontask2);

    }
    public void ontask()
    {
        button.interactable = false;
        button2.interactable = false;
        button.enabled = false;
        button2.enabled = false;
        button.gameObject.active = false;
        button2.gameObject.active = false;

        //Debug.Log("Wrong Answer");
       
        button3.GetComponent<Image>().color = Color.red;
        button3.gameObject.active = true;
        button3.GetComponentInChildren<Text>().text = "Wrong answer";
      
        
     

        PLayer.heath--;
        SaveData.StoreHealth = PLayer.heath;
        if (PLayer.heath <= 0)
        {
            SaveData.StoreHealth = 0;
            SaveData.Storescore = 0;
            SceneManager.LoadScene("Main Menu");
        }
        //Debug.Log(PLayer.heath);
        //Debug.Log("twice");
        if (PLayer.score == 8)
            SceneManager.LoadScene("Level0_1");
        if (PLayer.score == 12)
            SceneManager.LoadScene("Level0_2");
        if (PLayer.score == 23)
            SceneManager.LoadScene("Winner");


    }
    public void ontask2()
    {
       // Debug.Log("Correct");

     
        button3.GetComponent<Image>().color = Color.green;
        button3.GetComponentInChildren<Text>().text = "Correct";
        button.enabled = false;
        button2.enabled = false;
        button2.gameObject.active = false;
        button3.gameObject.active = true;
        button.gameObject.active = false;
        if (PLayer.score == 8)
            SceneManager.LoadScene("Level0_1");
        if (PLayer.score == 12)
            SceneManager.LoadScene("Level0_2");
        if (PLayer.score == 23)
            SceneManager.LoadScene("Winner");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
