using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;


public class RadioButtons : MonoBehaviour
{
  //  public RadioButtons radioButtons;
    public Toggle choose1;
    public Toggle choose2;
    public Toggle choose3;
    public Button button;
    public Button buttont;
    public Text text;


    // Start is called before the first frame update
    void Start()
    {
        //radioButtons.GetComponent<RadioButtons>();
        choose1.GetComponent<Toggle>();
        choose2.GetComponent<Toggle>();
        choose3.GetComponent<Toggle>();
        button.GetComponent<Button>();
        buttont.GetComponent<Button>();
        buttont.gameObject.active = false;
        button.onClick.AddListener(checkanswer);

        text.GetComponent<Text>();


    }
   

    public void checkanswer()
    {
     
        
            if (choose1.isOn)
            {

            text.text = "Wrong Answer,Try Again";
            text.color = Color.red;
       
             StartCoroutine(Wait());
      

        }
            if (choose2.isOn)
            {
              text.text = "Wrong Answer,Try Again";
            text.color = Color.red;

            StartCoroutine(Wait());
         
        }
            if (choose3.isOn)
            {
                choose1.enabled = false;
                choose2.enabled = false;
                choose3.enabled = false;
                buttont.gameObject.active = true;
                button.gameObject.active = false;
                text.text = "Correct";
               text.color = Color.green;

            StartCoroutine(Wait());
                //buttont.GetComponent<Image>().color = Color.green;
                buttont.GetComponentInChildren<Text>().text = "Continue";
              

               
            }
        

    }
    IEnumerator Wait()
    {
        Debug.Log("Wait");
        yield return new WaitForSeconds(5f);
        text.text = "";
       
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
