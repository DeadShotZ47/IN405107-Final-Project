using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public Transform player; // ตัวผู้เล่นที่กล้องติดตามอยู่
    public float parallaxEffectMultiplier = 0.1f; // ค่าความเร็วในการขยับของพื้นหลัง

    private Vector3 lastPlayerPosition;

    void Start()
    {
        // บันทึกตำแหน่งของผู้เล่นเมื่อเริ่มต้น
        lastPlayerPosition = player.position;
    }

    void Update()
    {
        // คำนวณการเปลี่ยนแปลงตำแหน่งของผู้เล่น
        Vector3 deltaMovement = player.position - lastPlayerPosition;

        // ขยับพื้นหลังตามผู้เล่น โดยมี parallaxEffectMultiplier เป็นตัวควบคุมความเร็ว
        transform.position += new Vector3(deltaMovement.x * parallaxEffectMultiplier, deltaMovement.y * parallaxEffectMultiplier, 0);

        // อัปเดตตำแหน่งล่าสุดของผู้เล่น
        lastPlayerPosition = player.position;
    }
}
