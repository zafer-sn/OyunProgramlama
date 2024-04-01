using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    public Transform target;
    public float camera_speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        gameObject.transform.position = Vector3.Slerp(gameObject.transform.position, new Vector3(target.transform.position.x, target.transform.position.y, gameObject.transform.position.z), camera_speed);
    }
}
