using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ChangeLevel : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<Button>();
        button.onClick.AddListener(ontask);
    }
    public void ontask()
    {

        if (PLayer.score == 8)
            SceneManager.LoadScene("Level0_1");
        if (PLayer.score == 12)
            SceneManager.LoadScene("Level0_2");
        if(PLayer.score==23)
            SceneManager.LoadScene("Winner");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
