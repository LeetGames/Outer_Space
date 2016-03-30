using UnityEngine;
using System.Collections;

public class scri : MonoBehaviour {
    public GameObject player;
    EdgeCollider2D coll;
    SpriteRenderer rend;
	// Use this for initialization

	void Start () {
        coll = GetComponent<EdgeCollider2D>();
        player = GameObject.Find("Player");
        rend = player.GetComponent<SpriteRenderer>();
    }
	
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name + " entered");
        if (rend.sortingOrder == 2)
        {
            rend.sortingOrder = 1;
        }
        else
        {
            rend.sortingOrder = 2;
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
