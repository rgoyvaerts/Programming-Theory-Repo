using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereInteraction : ShapesInteraction
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        TransformShape();
    }

    //POLYMORPHISM
    public override void TransformShape()
    {
        //Change scale in y to be able to see rotation of sphere
        if(transform.localScale.y <= 10)
        {
            transform.localScale = new Vector3(10, 20, 10);
            Debug.Log("Scale Changed");
        }

        transform.Rotate(Vector3.forward, 45);

        //INHERITENCE
        ChangeColor();
    }
}
