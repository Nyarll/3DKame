using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{

    public float speed = 20;

    float inputHorizontal;
    float inputVertical;

    private Rigidbody rb;
    GameObject Camera;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Camera = GameObject.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
        // カーソルキーの入力を取得
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        // カーソルキーの入力に合わせて移動方向を設定
        var movement = new Vector3(inputHorizontal, 0, inputVertical);
        var rotmove = Quaternion.Euler(0, Camera.transform.eulerAngles.y, 0) * movement;

        // Ridigbody に力を与えて玉を動かす
        rb.AddForce(rotmove * speed);

        if(transform.position.y < -100)
        {
            transform.position = new Vector3(0, 100, 0);
        }

        Debug.Log(transform.localScale.x);
    }
}
