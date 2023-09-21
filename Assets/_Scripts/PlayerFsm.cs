using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFsm : MonoBehaviour
{
    private MouseRotate rotateToMouse;

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rotateToMouse = GetComponent<MouseRotate>();
    }

    // Start is called before the first frame update

    private void UpdateRotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotateToMouse.Rotate(mouseX, mouseY);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateRotate();
    }
}
