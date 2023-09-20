using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
            
    }

    void loadScene()
    {
        SceneManager.LoadScene("Map_Hosp1");
    }

    public void OnClickStartBut()
    {
        loadScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
