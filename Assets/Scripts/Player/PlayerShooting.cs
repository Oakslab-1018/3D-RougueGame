using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    float time = 0f;
    float timeBetweenShoot = 0.15f;//�������

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
        //ʵ����һ���ӵ�����
        GameObject obj = Instantiate(bulletObj);
        //���ö����λ��
        obj.transform.position = bulletPos.position;
        
        //�Ƕ�
        obj.transform.eulerAngles = bulletPos.eulerAngles;
    }
}
