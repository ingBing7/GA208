using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //floats for movespeed and seed/plant values

    private float moveSpeed = 5f;
    public float seedsLeft = 5f;
    public float plantsPlanted = 0f;

    //rigidbody2D

    private Rigidbody2D rb;

    //Vector 2 for move input

    private Vector2 moveInput;

    //GameObjects and Text Objects

    public GameObject plantPrefab;

    public TextMeshProUGUI seedsText;
    public TextMeshProUGUI plantsText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //grabs the rb component from the player object (which this script is attached to) at the beginning of this script.
    }

    void Update()
    {
        rb.linearVelocity = moveInput * moveSpeed;
        //pushes the rigidbody forward based on the move input and move speed. multiplies the move input by 5, which is the rate at which the player object is moved.
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        //grabs the moveinput vector2 from the input the player gives, in this case WASD, as that's the inputs plugged into the move function in the input system.
    }

    public void Plant(InputAction.CallbackContext context)
    {
        if(context.performed) //prevents triple input bug when doing the input system this way.
        {
            if(seedsLeft > 0f) //only runs this function if the seedsLeft float is bigger than 0. 
            {
                //Debug.Log("planting");
                Instantiate(plantPrefab, transform.position, transform.rotation);
                //instantiates (spawns) a plantPrefab at the players transform position and rotation.

                seedsLeft--;
                plantsPlanted++;
                //subtracts 1 from the seedsLeft float, and adds 1 to the plantsPlanted float.

                seedsText.text = seedsLeft.ToString();
                plantsText.text = plantsPlanted.ToString();
                //updates text in UI when this if statement runs. 
            }
        }
    }
}
