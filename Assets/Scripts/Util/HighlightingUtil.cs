using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightingUtil {
    public static void HighlightGameObject(GameObject go, Material highlight)
    {
        Renderer foundRenderer;
        foundRenderer = go.GetComponent<Renderer>();
        if(!foundRenderer)
        {
            foundRenderer = go.GetComponentInChildren<Renderer>();
        }

        if(foundRenderer)
        {
            foundRenderer.material = highlight;
        }
        
    }
}
