using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObj : MonoBehaviour
{
    public float moveSpeed = 100f;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if(time>5)
        {
            Destroy(gameObject);
            time = 0;
        }
    }
}
