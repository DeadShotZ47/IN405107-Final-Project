using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMessageOnTrigger : MonoBehaviour
{
    public GameObject messagePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // ตรวจสอบว่าเป็นผู้เล่นหรือไม่
        {
            messagePanel.SetActive(true); // แสดงแผงข้อความ
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // ตรวจสอบว่าเป็นผู้เล่นหรือไม่
        {
            messagePanel.SetActive(false); // ซ่อนแผงข้อความ
        }
    }

}
