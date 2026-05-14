using UnityEngine;

public class ZonaSuelo : MonoBehaviour
{
    // Tipo de suelo
    public enum TipoSuelo { Normal, Hielo, Pegajosa }
    public TipoSuelo tipoActual = TipoSuelo.Normal;

    // Modificar propiedades
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            
            if (player != null)
            {
                if (tipoActual == TipoSuelo.Pegajosa)
                {
                    player.jumpImpulse = 5f; 
                }
                else
                {
                    player.jumpImpulse = 10f; 
                }
            }
        }
    }
}