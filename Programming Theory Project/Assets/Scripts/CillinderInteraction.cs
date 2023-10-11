using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CillinderInteraction : ShapesInteraction
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
       
        transform.Rotate(Vector3.forward, -45);

        //INHERITENCE
        ChangeColor();
    }
}
