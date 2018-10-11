using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    GameObject Target;
    public float speed;
    Vector3 scale;

	// Use this for initialization
	void Start () {
        Target = GameObject.Find("Ball");
        scale = Target.transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = Vector3.MoveTowards(this.transform.position, Target.transform.position, speed * Time.deltaTime);
	}

    void OnCollisionEnter(Collision collision)
    {
        //衝突判定
        if (collision.gameObject.tag == "Ball")
        {
            //相手のタグがBallならば、自分を消す
            Destroy(this.gameObject);
            Target.transform.localScale.Set(Target.transform.localScale.x + 1, Target.transform.localScale.y + 1, Target.transform.localScale.z + 1);

        }
    }
}
