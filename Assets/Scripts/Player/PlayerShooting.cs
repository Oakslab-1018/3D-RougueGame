using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    float time = 0f;
    float timeBetweenShoot = 0.15f;//攻击间隔

    public GameObject bulletObj;
    public Transform bulletPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetMouseButtonDown(0)&&time>=timeBetweenShoot)
        {
            Shooting();
        }
    }

    private void Shooting()
    {
        time = 0;
        //实例化一个子弹对象
        GameObject obj = Instantiate(bulletObj);
        //设置对象的位置
        obj.transform.position = bulletPos.position;
        
        //角度
        obj.transform.eulerAngles = bulletPos.eulerAngles;
    }
}
