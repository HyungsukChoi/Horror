using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRay();
    }

    void PlayerRay()
    {
        if (Physics.Raycast(this.transform.position, transform.forward, out hit))
        {
            Debug.DrawRay(this.transform.position, transform.forward * 1000f, Color.green);
            if (hit.collider.tag == "Item")
            {
                Debug.Log("getable");
                // hit.collider.GetComponent<MeshRenderer>().
            }
        }
    }
}
