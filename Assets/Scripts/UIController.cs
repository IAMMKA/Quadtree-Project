using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public InputField shapeCountField;

    private void Update()
    {
        
    }

    public void OnShapeCountChanged()
    {
        Settings.shapeCount = int.Parse(shapeCountField.text);
    }

  

}
