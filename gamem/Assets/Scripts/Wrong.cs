using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Wrong : MonoBehaviour
{

    public Button button;
    public Button button2;


    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<Button>();
        button2.GetComponent<Button>();
        button.onClick.AddListener(ontask);
    }
    public void ontask()
    {
        Debug.Log("how");


        gameObject.active = false;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
