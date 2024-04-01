using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeControl : MonoBehaviour
{
    public GameObject mavi_kup;
    // Start is called before the first frame update
    void Start()
    {
        mavi_kup = GameObject.Find("Blue");
        mavi_kup.GetComponent<SpriteRenderer>().color = Color.gray;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(4f);
        gameObject.AddComponent<Rigidbody2D>();
        yield return new WaitForSeconds(3f);
        mavi_kup.GetComponent<SpriteRenderer>().color = Color.green;
    }
}
