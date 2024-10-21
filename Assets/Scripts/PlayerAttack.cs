using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackDamage = 100f;
    private int enemyLayer;
    PlayerMoveControl playerMoveControl;
    public float forceX;
    public float forceY;
    public float duration;
    // Start is called before the first frame update
    void Start()
    {
        enemyLayer = LayerMask.NameToLayer("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == enemyLayer)
        {
            collision.GetComponent<Enemy>().TakeDamage(attackDamage);
            //StartCoroutine(playerMoveControl.KnockBack(forceX, forceY, duration, transform));
        }
    }
}
