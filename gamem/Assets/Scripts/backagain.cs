using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backagain : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SaveData.x);
        Debug.Log(SaveData.y);
        Debug.Log(SaveData.Storescore);
       // SceneManager.LoadScene(SaveData.sceneHistory[SaveData.sceneHistory.Count - 1], LoadSceneMode.Single);
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
