using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    Rigidbody2D rbody;
    Animator anim;

	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 move_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if(move_vector!= Vector2.zero)
        {
            anim.SetBool("iswalking", true);
            anim.SetFloat("input_x", move_vector.x);
            anim.SetFloat("input_y", move_vector.y);
        }
        else
        {
            anim.SetBool("iswalking", false);
        }

        if (move_vector.x !=0 && move_vector.y != 0)
        {
        rbody.MovePosition(rbody.position + move_vector * 10 * Time.deltaTime);
        }
        else
        {
        rbody.MovePosition(rbody.position + move_vector * 15 * Time.deltaTime);
        }

    }
}
