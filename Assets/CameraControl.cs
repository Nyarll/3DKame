using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    GameObject targetObj;
    Vector3 targetPos;

    void Start()
    {
        targetObj = GameObject.Find("Ball");
        targetPos = targetObj.transform.position;
    }

    void Update()
    {
        // targetの移動量分、自分（カメラ）も移動する
        transform.position += targetObj.transform.position - targetPos;
        targetPos = targetObj.transform.position;

        // マウスの右クリックを押している間
        if (Input.GetMouseButton(1))
        {
            // マウスの移動量
            float mouseInputX = Input.GetAxis("Mouse X") * 2;
            float mouseInputY = -Input.GetAxis("Mouse Y") * 2;
            // targetの位置のY軸を中心に、回転（公転）する
            transform.RotateAround(targetPos, Vector3.up, mouseInputX * Time.deltaTime * 200f);
            // カメラの垂直移動（※角度制限なし、必要が無ければコメントアウト）
            if (transform.rotation.x < (float)90.0)
            {
                transform.RotateAround(targetPos, transform.right, mouseInputY * Time.deltaTime * 200f);
            }
        }
    }
}
