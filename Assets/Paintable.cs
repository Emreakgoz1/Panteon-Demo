using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintable : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] GameObject Brush;
    [SerializeField] float BrushSize;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var Ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(Ray,out hit))
            {
                var go = Instantiate(Brush, hit.point + Vector3.down * 0.1f, Quaternion.identity, transform);
                go.transform.localScale = Vector3.one * BrushSize;

            }

        }


    }
}
