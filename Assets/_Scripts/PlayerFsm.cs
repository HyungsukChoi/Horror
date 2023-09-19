using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFsm : MonoBehaviour
{
    public static PlayerFsm Instance;


    private void Awake()
    {
        #region Singleton
        if (Instance == null)
            Instance = this;
        #endregion
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
