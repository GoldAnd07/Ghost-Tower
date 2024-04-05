using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость перемещения игрока

    private Rigidbody2D rb; // Ссылка на компонент Rigidbody2D

    private Vector2 moveDirection; // Направление движения игрока

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Получаем компонент Rigidbody2D при запуске
    }

    void Update()
    {
        // Получаем ввод от клавиатуры
        moveDirection.x = Input.GetAxis("Horizontal");
        moveDirection.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        // Перемещаем игрока в соответствии с вводом
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}

