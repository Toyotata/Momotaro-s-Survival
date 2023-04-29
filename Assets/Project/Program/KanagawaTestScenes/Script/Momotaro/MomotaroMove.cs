using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomotaroMove : MonoBehaviour
{
    // 移動時の加算用変数
    float vx = 0;
    float vy = 0;

    // 移動スピード
    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 毎フレーム数値を初期化
        vx = 0;
        vy = 0;

        // 横移動
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            vx = -speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            vx = speed;
        }

        // 縦移動
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            vy = speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            vy = -speed;
        }

        // 実際の移動処理
        this.transform.Translate(vx / 50, vy / 50, 0);
    }
}
