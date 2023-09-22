using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFsm : MonoBehaviour
{
    public Camera playerCam;
    private MouseRotate rotateToMouse;

    [SerializeField]
    private float moveSpeed = 3f;
    float mouseX, mouseY;

    //public float height = 1;
    //public float rotSpeed;      // 회전 속도
    //public float currentRot;

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rotateToMouse = playerCam.GetComponent<MouseRotate>();
    }

    // Start is called before the first frame update

    private void UpdateRotate()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        rotateToMouse.Rotate(mouseX, mouseY);
    }

    private void PlayerMove()
    {
        float moveX = Input.GetAxis("Vertical");
        float moveZ = Input.GetAxis("Horizontal");

        gameObject.transform.Translate(Vector3.forward * moveX * moveSpeed * Time.deltaTime);
        //playerAnim.SetFloat("Speed", moveX * moveSpeed * Time.deltaTime);
        Debug.Log(moveX);

        gameObject.transform.Translate(Vector3.right * moveZ * moveSpeed * Time.deltaTime);
    }


    // Update is called once per frame
    void Update()
    {
        UpdateRotate();
        //  PlayerMove();
    }
}
