using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayorLearn : MonoBehaviour
{
    public Button button;
    public Button button2;
    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<Button>();
        button.onClick.AddListener(ontask);
        button2.GetComponent<Button>();
        button2.onClick.AddListener(ontask1);
    }
    public void ontask()
    {
        SceneManager.LoadScene("Level0");
    }
    public void ontask1()
    {
        SceneManager.LoadScene("Know1");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
