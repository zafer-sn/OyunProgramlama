using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public float health, damage;
    bool is_busy = false;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = health;
        slider.maxValue = health;
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
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "colcontrol")
        {
            print("Selam");
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
        slider.value = health;
        AmIDead();

    }

    void AmIDead()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
