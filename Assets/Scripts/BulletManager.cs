using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public float damage, life_time;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, life_time);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
