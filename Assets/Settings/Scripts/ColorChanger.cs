using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class ColorChanger : MonoBehaviour
{
    //TODO: Create a variable to hold our sprite renderer component 
    private SpriteRenderer spriteRenderer; //this will override the previous renderer. 
    public Color spriteColor = Color.blue; //this is to help with designers so they can easily change things without wasting everyones times 
    
    //awake runs when an object is created 
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
           
                //TODO: Change the color of our sprite to Blue 
                spriteRenderer.color = spriteColor; //read it as the object being refered to sprit render's color is now equal to blue 
        }
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //Do this if the first frame the P key is pressed down 
            //change to a random color 
            spriteRenderer.color = GetRandomColor();
        }
        
    }
    private Color GetRandomColor()
    {
        Color color; 
        color.r = Random.Range(0.0f,1.0f);
        color.g = Random.Range(0.0f,1.0f);
        color.b = Random.Range(0.0f, 1.0f);
        color.a = 1.0f; 
            return color;
    }
}
