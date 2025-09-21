using UnityEngine;
using UnityEngine.InputSystem; // Required for the new GET  Input System


public class MovePosition : MonoBehaviour
{
    //TODO: Create a variable to hold our sprite renderer component 
    private SpriteRenderer spriteRenderer; //this will override the previous renderer. 
    public float moveSpeed = 5f;

    private void Awake()
    {
        //load sprit rendere into the component to that variable 
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();//i could take out this.gameObject and just refer to get component 
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (spriteRenderer == null)
        {
            Debug.Log("Error!Sprite Renderer is null");
        }
        else
        {

            //TODO: Change the posistion of our sprite to 
            transform.position = new Vector3(2, 2, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //Do this if the first frame the P key is pressed down 
            //change to a random color 
            transform.position = new Vector3(4, 4, 0);
        }
    }
    
}
