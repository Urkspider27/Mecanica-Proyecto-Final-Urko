using UnityEngine;

public class Burbuja : MonoBehaviour
{
    // Puntos otorgados
    public int pointsValue = 10;

    // Detectar colisión
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager gm = Object.FindFirstObjectByType<GameManager>();
            if (gm != null)
            {
                gm.AddScore(pointsValue);
            }
            
            // Destruir burbuja
            Destroy(gameObject);
        }
    }
}