using System;
using UnityEngine;

public class SpriteRenderController : MonoBehaviour {

    public Sprite flag;
    public Sprite svaston;
    private Sprite current;
	// Use this for initialization
	void Start () {
        current = flag;
	}

    // Update is called once per frame
    void Update() {
        this.GetComponent<SpriteRenderer>().sprite = current;
	}

    void OnMouseEnter()
    {
        if (Input.GetMouseButton(0))
        {
            ChangeSprite();

        }

    }
    private void ChangeSprite()
    {
        if (current.Equals(flag))
        {
            current = svaston;
        }
        else
        {
            current = flag;
        }
    }

    
}
