using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    //public GameObject startUI;
    //public Button startBut;
    //public Button continueBut;
    //public Button exitBut;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStart()
    {
        // 새로운 씬 불러오기
        SceneManager.LoadScene("MainScene");
    }

    public void OnClickContinue()
    {
        // 저장된 씬 불러오기
        SceneManager.LoadScene("SavedScene");
    }

    public void OnClickExit()
    {

    }
}
