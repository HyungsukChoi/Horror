using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class MouseRotate : MonoBehaviour
{
    public static MouseRotate Instance;
    // 카메라 회전속도 x,y
    [SerializeField]
    private float camRotateSpeedX = 3;
    [SerializeField]
    private float camRotateSpeedY = 4;

    // 최대 회전 범위 X
    private float limitMinX = -70;
    private float limitMaxX = 50;

    public  float eulerAngleX;
    public float eulerAngleY;

    private void Awake()
    {
        #region Singleton
        if (Instance == null)
            Instance = this;
        #endregion
    }

    public void Rotate(float mouseX, float mouseY)
    {
        eulerAngleY += mouseX * camRotateSpeedY;
        eulerAngleX -= mouseY * camRotateSpeedX;

        eulerAngleX = ClampAngle(eulerAngleX, limitMinX, limitMaxX);

        transform.rotation = Quaternion.Euler(eulerAngleX, eulerAngleY, 0);
    }

    public float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }

}
