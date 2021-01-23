
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Knz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.active = false;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(SaveData.knz);
        if (SaveData.knz == 0)
        {
            SceneManager.LoadScene("Quiz1");
            SaveData.knz++;
        }
        else if (SaveData.knz == 1)
        {
            SceneManager.LoadScene("Quiz2");
            SaveData.knz++;
        }
        else if (SaveData.knz == 2)
        {
            SceneManager.LoadScene("Quiz3");
            SaveData.knz++;

        }
           
    }
// Update is called once per frame
void Update()
    {
        
    }
}
