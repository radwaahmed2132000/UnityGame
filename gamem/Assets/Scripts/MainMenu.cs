using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<Button>();
        button.onClick.AddListener(ontask1);
    }
    public void ontask1()
    {
        SceneManager.LoadScene("Main Menu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
