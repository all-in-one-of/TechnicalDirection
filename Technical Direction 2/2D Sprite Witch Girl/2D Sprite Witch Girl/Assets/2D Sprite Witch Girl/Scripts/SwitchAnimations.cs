using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAnimations : MonoBehaviour
{
    
    //Boolean that will determine if the sprite image should be rotated.
    bool rotation = true;

    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        //When the right arrow key is pressed and the sprite is facing to the left, the sprite will now face right.
        if (Input.GetKey (KeyCode.RightArrow) && rotation == true) {
            transform.Rotate (0, 180, 0);
            rotation = false;
        }
        //When the left arrow key is pressed and the sprite is facing to the right, the sprite will now face left.
        if(Input.GetKey(KeyCode.LeftArrow) && rotation == false)
        {
            transform.Rotate(0,180,0);
            rotation = true;
        }
        //While the Arrow Keys are being pressed, the Moving parameter in the Animator will become true.
        //This will change the animation on the sprite to "Run".
        if (Input.GetKey (KeyCode.LeftArrow)) 
        {
            anim.SetBool("Moving", true);
        }
        else if(Input.GetKey (KeyCode.RightArrow))
        {
            anim.SetBool("Moving", true);
        }
        //When the arrow keys are not being pressed, the Moving parameter will become false, switching back to the Idle animation.
        else if(Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("Moving", false);
        }

        if (Input.GetKeyDown (KeyCode.Space))
        {
            anim.SetBool("Jumping", true);
        }

    }
}
