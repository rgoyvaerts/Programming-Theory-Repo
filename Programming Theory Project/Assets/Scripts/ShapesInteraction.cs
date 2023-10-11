using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapesInteraction : MonoBehaviour
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
        Debug.Log("Shape clicked");
        TransformShape(); 
    }

    //POLYMORPHISM
    public virtual void TransformShape()
    {
        transform.Rotate(Vector3.forward, 45);
        ChangeColor();
    }

    protected void ChangeColor()
    {
        List<string> myColors = new List<string>();

        myColors.Add("blue");
        myColors.Add("green");
        myColors.Add("pink");
        myColors.Add("red");
        myColors.Add("yellow");

        int randomnumber = Random.Range(0, myColors.Count);
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material = Resources.Load<Material>(myColors[randomnumber]);
        Debug.Log("Color Changed");
    }
}
