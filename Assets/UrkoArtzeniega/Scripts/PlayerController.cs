using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    // Variables movimiento
    public float moveForce = 15f;
    public float jumpImpulse = 10f;
    public float maxSpeed = 8f;
    
    private Rigidbody rb;
    private GameManager gm;

    // Inicialización
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gm = Object.FindFirstObjectByType<GameManager>();
    }

    // Físicas
    void FixedUpdate()
    {
        if (gm != null && gm.isGameOver) return;

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0.0f, moveZ);

        // Aplicar fuerza
        rb.AddForce(movement * moveForce, ForceMode.Force);

        // Limitar velocidad
        if (rb.linearVelocity.magnitude > maxSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;
        }
    }

    // Input salto
    void Update()
    {
        if (gm != null && gm.isGameOver) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Aplicar impulso
            rb.AddForce(Vector3.up * jumpImpulse, ForceMode.Impulse);
        }
    }
}