using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Variables UI
    public int score = 0;
    public int lives = 3;
    public bool isGameOver = false;

    // Suma puntos
    public void AddScore(int points)
    {
        if (isGameOver) return;
        score += points;
        Debug.Log("Puntuación: " + score);
    }

    // Resta vidas
    public void LoseLife()
    {
        if (isGameOver) return;
        lives--;
        Debug.Log("Vidas: " + lives);

        if (lives <= 0)
        {
            GameOver();
        }
    }

    // Fin del juego
    private void GameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over");
    }
}