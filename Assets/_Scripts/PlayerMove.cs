using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float h = 0.0f;
    private float v = 0.0f;
    // private float r = 0.0f;

    float moveSpeed = 5.0f;
    // float rotSpeed = 180f;
    Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }
    void Move()
    {
        h= Input.GetAxis("Horizontal");
        v= Input.GetAxis("Vertical");
        //�����¿� �̵� ���� ���� ���
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        //Translate(�̵� ���� * �ӵ� * ������ * Time.deltaTime, ������ǥ)
        tr.Translate(moveDir.normalized * moveSpeed * Time.deltaTime, Space.Self);
        //Vector3.up ���� �������� rotSpeed��ŭ�� �ӵ��� ȸ��
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
