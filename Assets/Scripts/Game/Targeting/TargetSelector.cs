using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TargetsInSight))]
public class TargetSelector : MonoBehaviour {

    public GameObject LastTarget;
    public GameObject SelectedTarget;
    public Material HighlightMaterial;
    private TargetsInSight Targets;
    private int selectedIndex = 0;
    void Start () {
        Targets = GetComponent<TargetsInSight>();
	}
	
    public void SelectTarget()
    {
        List<GameObject> targetsInSight = Targets.TargetsInView;
        //get order targets by distance
        targetsInSight.Sort((go1, go2) => 
            Vector3.Distance(gameObject.transform.position, go2.transform.position).CompareTo(
            Vector3.Distance(gameObject.transform.position, go1.transform.position))
          )  ;

        //then select the closest one
        //maintain an index so if this gets called again we get the next one
        if (selectedIndex >= targetsInSight.Count)
        {
            selectedIndex = 0;
        }

        if(targetsInSight.Count>0)
        {
            LastTarget = SelectedTarget;
            SelectedTarget = Targets.TargetsInView[selectedIndex++];

            //do some target highlighting
            if(HighlightMaterial)
            {
                HighlightingUtil.HighlightGameObject(SelectedTarget, HighlightMaterial);
            }
        }
        

        
    }
}
