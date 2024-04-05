using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeTrigger : MonoBehaviour
{
    public string sceneName; // Название сцены, на которую нужно переместить игрока

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Проверяем, что в триггер вошел объект с тегом "Player"
        {
            SceneManager.LoadScene(sceneName); // Загружаем указанную сцену
        }
    }
}