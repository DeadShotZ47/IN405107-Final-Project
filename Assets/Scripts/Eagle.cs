using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eagle : MonoBehaviour
{
    private float speed;
    private Transform player;
    private bool movingRight;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // สุ่มความเร็วเมื่อเกิด
        speed = Random.Range(3f, 8f);

        // ตรวจสอบว่านกเกิดจากขอบซ้ายหรือขอบขวาของจอ
        if (transform.position.x < player.position.x)
        {
            movingRight = true; // นกเคลื่อนที่ไปทางขวา
            transform.localScale = new Vector3(5, 5, 1); // หัน sprite ทางขวา
        }
        else
        {
            movingRight = false; // นกเคลื่อนที่ไปทางซ้าย
            transform.localScale = new Vector3(-5, 5, 1); // พลิก sprite หันทางซ้าย
        }
    }

    void Update()
    {
        // เคลื่อนที่นก
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        // ทำลาย object นกเมื่ออยู่ไกลจากผู้เล่นมากเกินไป
        if (Vector2.Distance(transform.position, player.position) > 100f)
        {
            Destroy(gameObject);
        }
    }
}
