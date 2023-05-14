using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // 수평 입력 (좌우 이동)
        float moveY = Input.GetAxisRaw("Vertical"); // 수직 입력 (상하 이동)

        Vector2 movement = new Vector2(moveX, moveY).normalized; // 입력 벡터 정규화

        rb.velocity = movement * moveSpeed; // 속도 적용
    }
}
