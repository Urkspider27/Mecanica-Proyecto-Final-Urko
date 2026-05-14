using UnityEngine;

public class CuboPeligroso : MonoBehaviour
{
    // Detectar colisión
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager gm = Object.FindFirstObjectByType<GameManager>();
            if (gm != null)
            {
                gm.LoseLife();
            }
        }
    }
}