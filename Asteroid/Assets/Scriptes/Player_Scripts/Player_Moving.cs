using UnityEngine;

public class Player_Moving : MonoBehaviour
{
    public float boostSpeed;
    private float boostInput;

    public float torque;
    public float turn;

    public Rigidbody2D rb;
    public Vector2 moveVector;

    public static Vector2 PostionOfPlayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        PostionOfPlayer = transform.position;
    }

    private void FixedUpdate()
    {
        BoostShip();
        RotateShip();
    }

    void BoostShip()
    {
        boostInput = Input.GetAxis("Vertical");
        if (boostInput > 0) 
        {
            rb.AddRelativeForce(Vector2.up * boostInput * boostSpeed);
        }
    }

    void RotateShip()
    {
        turn = Input.GetAxis("Horizontal");
        rb.AddTorque(-torque * turn);
    }
}
