using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    public float moveSpeed = 5.0f; // 移动速度
    
    

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
        // 获取WASD键的输入
        float x = Input.GetAxis("Horizontal"); // A和D键
        float z = Input.GetAxis("Vertical"); // W和S键
        Vector3 moveDirection = new Vector3(x, 0, z);
        moveDirection=moveDirection.normalized*moveSpeed*Time.deltaTime;
        // 移动角色
        rb.MovePosition(transform.position+moveDirection);
    }
    private void Rotate()
    {

        // 鼠标控制方向
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // 从鼠标位置发射射线

        int grouNdLayer = LayerMask.GetMask("Ground");
        RaycastHit groundHit;//射线触碰地面位置
        if(Physics.Raycast(ray,out groundHit,100,grouNdLayer))
        {
            Vector3 v3=groundHit.point-transform.position;
            v3.y = 0;

            Quaternion quaternion = Quaternion.LookRotation(v3);
            rb.MoveRotation(quaternion);
        }
    }
}

