using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Items
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Get(GameObject Item)
    {
        Destroy(Item.gameObject);
        throw new System.NotImplementedException();
    }

    public override void Use(GameObject Item)
    {
        throw new System.NotImplementedException();
    }
}
