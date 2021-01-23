using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Learn2 : MonoBehaviour
{
    public Button buttont;
    // Start is called before the first frame update
    void Start()
    {
        buttont.onClick.AddListener(change);
    }
    void change()
    {
        SceneManager.LoadScene("Learn2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
