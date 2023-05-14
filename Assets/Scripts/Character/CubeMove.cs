using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // 수평 입력 (좌우 이동)
        float moveZ = Input.GetAxisRaw("Vertical"); // 수직 입력 (z축 이동)

        Vector3 movement = new Vector3(moveX, 0f, moveZ).normalized; // 입력 벡터 정규화

        rb.velocity = movement * moveSpeed; // 속도 적용
    }
}
