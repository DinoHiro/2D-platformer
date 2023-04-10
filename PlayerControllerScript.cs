using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    // animaatiot on kommentoitu kun niitä ei vielä ole
    public PlayerStats stats;
    //public Animator animator;
    public Rigidbody2D rb2D;

    public Transform groundCheckPosition;
    public float groundCheckRadius;
    public LayerMask groundCheckLayer;
    public static bool grounded;

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        // groundcheck
        if (Physics2D.OverlapCircle(groundCheckPosition.position, groundCheckRadius, groundCheckLayer))
        {
            grounded = true;
            Debug.Log("grounded true");
        }
        else
        {
            grounded = false;
            Debug.Log("grounded false");
        }
    }
}
