using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float health, damage;
    bool is_busy = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !is_busy)
        {
            is_busy = true;
            collision.GetComponent<PlayerManager>().GetDamage(damage);
        }
        if (collision.tag == "Bullet")
        {
            GetDamage(collision.GetComponent<BulletManager>().damage);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            is_busy = false;
        }

    }

    public void GetDamage(float damage)
    {
        if ((health - damage) >= 0)
            health -= damage;
        else
            health = 0;
        AmIDead();

    }

    void AmIDead()
    {
        if (health <= 0)
        {

        }
    }
}
