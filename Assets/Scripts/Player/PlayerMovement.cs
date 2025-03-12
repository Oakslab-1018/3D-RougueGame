using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    public float moveSpeed = 5.0f; // �ƶ��ٶ�
    
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
        Rotate();
    }
    private void Move()
    {
        // ��ȡWASD��������
        float x = Input.GetAxis("Horizontal"); // A��D��
        float z = Input.GetAxis("Vertical"); // W��S��
        Vector3 moveDirection = new Vector3(x, 0, z);
        moveDirection=moveDirection.normalized*moveSpeed*Time.deltaTime;
        // �ƶ���ɫ
        rb.MovePosition(transform.position+moveDirection);
    }
    private void Rotate()
    {

        // �����Ʒ���
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // �����λ�÷�������

        int grouNdLayer = LayerMask.GetMask("Ground");
        RaycastHit groundHit;//���ߴ�������λ��
        if(Physics.Raycast(ray,out groundHit,100,grouNdLayer))
        {
            Vector3 v3=groundHit.point-transform.position;
            v3.y = 0;

            Quaternion quaternion = Quaternion.LookRotation(v3);
            rb.MoveRotation(quaternion);
        }
    }
}

