using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    Animator playerAnim;
    public float moveSpeed = 5f; // �̵� �ӵ�

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


        // Ư�������� �Ѿ�� �ʰ� ����ó��

        this.transform.localRotation = Quaternion.Euler(0, MouseRotate.Instance.eulerAngleY, 0);
    }
    
    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }
}
