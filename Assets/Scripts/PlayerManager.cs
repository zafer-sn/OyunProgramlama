using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public float health;
    bool dead = false;

    public Transform barrel_position;
    public GameObject barrel;

    public float power;
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
        if (Input.GetMouseButtonDown(0) && EventSystem.current.currentSelectedGameObject == null)
        {
            Shooting();
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
            dead = true;
        }
    }

    void Shooting()
    {
        GameObject temp_object;
        temp_object = Instantiate(barrel, barrel_position.position, Quaternion.identity);
        temp_object.GetComponent<Rigidbody2D>().AddForce(barrel_position.forward * power);
    }
}
