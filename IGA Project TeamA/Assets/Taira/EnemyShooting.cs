using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {
    
    //弾のプレハブ
    public GameObject Bullet;
    //弾の発射点
    public Transform PosR;
    public Transform PosL;
    public Transform PosU;
    public Transform PosD;
    //発射パターン
    int pattern = 0;

    public float speed;
    float time = 0;
    public float interval = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        //if (Input.GetKeyDown(KeyCode.Z)){
        if (time > interval)
        {
            
            switch(pattern){        
                case 0:
                    ShotL();
                    ShotR();
                    pattern++;
                    break;
                case 1:
                    ShotU();
                    ShotD();
                    pattern = 0;
                    break;
                
            }
            time = 0;
        }
	}

    void ShotL()
    {
        // 弾丸の複製
        GameObject bullets = GameObject.Instantiate(Bullet) as GameObject;

        Vector3 force;
        force = this.gameObject.transform.right * speed;
        // Rigidbodyに力を加えて発射
        bullets.GetComponent<Rigidbody>().AddForce(-(force));
        // 弾丸の位置を調整
        bullets.transform.position = PosL.position;
    }

    void ShotR()
    {
        // 弾丸の複製
        GameObject bullets = GameObject.Instantiate(Bullet) as GameObject;

        Vector3 force;
        force = this.gameObject.transform.right * speed;
        // Rigidbodyに力を加えて発射
        bullets.GetComponent<Rigidbody>().AddForce(force);
        // 弾丸の位置を調整
        bullets.transform.position = PosR.position;
    }

    void ShotU()
    {
        // 弾丸の複製
        GameObject bullets = GameObject.Instantiate(Bullet) as GameObject;

        Vector3 force;
        force = this.gameObject.transform.up * speed;
        // Rigidbodyに力を加えて発射
        bullets.GetComponent<Rigidbody>().AddForce(force);
        // 弾丸の位置を調整
        bullets.transform.position = PosU.position;
    }

    void ShotD()
    {
        //弾丸の複製
        GameObject bullets = GameObject.Instantiate(Bullet) as GameObject;

        Vector3 force;
        force = this.gameObject.transform.up * speed;
        //Rigitbodyに力を加えて発射
        bullets.GetComponent<Rigidbody>().AddForce(-(force));
        //弾丸の位置の調整
        bullets.transform.position = PosD.position;
    }
}
