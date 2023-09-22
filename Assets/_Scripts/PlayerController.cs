using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayerMove()
    {
        float moveX = Input.GetAxis("Vertical");
        float moveZ = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * moveX * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * moveZ * moveSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }
}
