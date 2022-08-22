using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
  Vector3 difference = Vector3.zero;

    private void OnMouseDown()
    {
      difference = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    }
    
     void OnMouseDrag()
    {
      transform.position = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }
}
