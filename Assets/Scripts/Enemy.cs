using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float helth;

    protected Rigidbody2D rb;
    protected Animator anim;
    private EnemyAttack enemyAttack;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        enemyAttack = GetComponentInChildren<EnemyAttack>(); // รับ EnemyAttack จากลูก
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float damage)
    {
        helth -= damage;
        if (helth <= 0)
        {
            GetComponent<AudioSource>().Play();
            anim.SetTrigger("Death");
            if (enemyAttack != null)
            {
                PolygonCollider2D collider = enemyAttack.GetComponent<PolygonCollider2D>();
                if (collider != null)
                {
                    collider.enabled = false;
                }
            }
            Destroy(gameObject, 0.3f);
        }
    }
}
