using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
[RequireComponent(typeof(TargetTag))]
public class TargetsInSight : MonoBehaviour {

    [SerializeField]
    private List<GameObject> targetsInView;
    public List<GameObject> TargetsInView
    {
        get
        {
            targetsInView.RemoveAll(go => go == null);
            return targetsInView;
        }
    }

    private Camera Eyes;
    private TargetTag Targets;
    private void Start()
    {
        Eyes = GetComponent<Camera>();
        Targets = GetComponent<TargetTag>();
    }
    void Update () {
        //calculate an area within the camera that are objects in view
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(Eyes);
        foreach (GameObject entity in Targets.TargetsInRange)
        {
            if(entity)
            {
                Bounds bounds = new Bounds(entity.transform.position, Vector3.one);
                // bounds.Encapsulate(entity.transform.position);

                bool isInBounds = GeometryUtility.TestPlanesAABB(planes, bounds);
                if (isInBounds)
                {
                    if (targetsInView.Contains(entity) == false)
                    {
                        targetsInView.Add(entity);
                    }
                }
            }
        }

        //remove any objects from the view if they're not in range
        foreach (GameObject entity in Targets.TargetsInRange)
        {
            if (entity)
            {
                Bounds bounds = new Bounds(entity.transform.position, Vector3.one);
                bool isInBounds = GeometryUtility.TestPlanesAABB(planes, bounds);
                if (isInBounds == false)
                {
                    targetsInView.Remove(entity);
                }
            }
        }
    }
}
