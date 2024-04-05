using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleQuestSystem : MonoBehaviour
{
    public GameObject door; // Ссылка на объект двери

    void Update()
    {
        // Проверяем нажатие клавиши [E]
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Пытаемся найти коллайдер предмета в радиусе 0.5 от игрока
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.5f);
            foreach (Collider2D collider in colliders)
            {
                if (collider.gameObject == gameObject) // Проверяем, что найденный коллайдер принадлежит этому предмету
                {
                    Destroy(gameObject); // Уничтожаем предмет
                    door.SetActive(true); // Включаем дверь
                    break; // Прерываем цикл, чтобы не обрабатывать другие коллайдеры
                }
            }
        }
    }
}


