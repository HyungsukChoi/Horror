using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    Animator playerAnim;
    public float moveSpeed = 5f; // 이동 속도

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    void PlayerMove()
    {
        float moveX = Input.GetAxis("Vertical");
        float moveZ = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * moveX * moveSpeed * Time.deltaTime);
        playerAnim.SetFloat("Speed", moveX * moveSpeed * Time.deltaTime);

        transform.Translate(Vector3.right * moveZ * moveSpeed * Time.deltaTime);


        // 특정각도를 넘어가지 않게 예외처리

        this.transform.localRotation = Quaternion.Euler(0, MouseRotate.Instance.eulerAngleY, 0);
    }
    
    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }
}
