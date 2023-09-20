using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    
    public Camera fpsCam;
    public Transform PlayerTr;
    public float height = 1;
    public float moveSpeed = 5f; // �̵� �ӵ�
    public float rotSpeed = 3f;      // ȸ�� �ӵ�
    public float currentRot;

    // Start is called before the first frame update
    void Start()
    {
        PlayerTr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Vertical");
        float moveZ = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * moveX * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * moveZ * moveSpeed * Time.deltaTime);

        float rotateX = Input.GetAxis("Mouse Y") * rotSpeed;
        float rotateY = Input.GetAxis("Mouse X") * rotSpeed;

        currentRot = rotateX;
        // Ư�������� �Ѿ�� �ʰ� ����ó��
        currentRot = Mathf.Clamp(currentRot, -80f, 80f);

        this.transform.localRotation *= Quaternion.Euler(0, rotateY, 0);
        fpsCam.transform.localEulerAngles = new Vector3(currentRot, 0, 0);
    }
}
