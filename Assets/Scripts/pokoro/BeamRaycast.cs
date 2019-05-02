using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class BeamRaycast : MonoBehaviour
{
    [SerializeField] Transform muzzle;
    [SerializeField] GameObject ricoshetObject;
    [SerializeField] Transform hitObject;

    // [SerializeField] LineRenderer beam;
    float beamDistance;
    RaycastHit hit;


    void Start()
    {
        beamDistance = GetComponent<LineRenderer>().GetPosition(1).z;
    }

    void Update()
    {
        //Get the ray from the muzzle to the length of the beam
        var ray = new Ray(muzzle.position, muzzle.transform.forward);

        //If the ray hits 
        if (Physics.Raycast(ray, out hit, beamDistance))
        {
            //Position the hitObject at point of hit/collision
            hitObject.transform.position = hit.point;

            //Align with the wall
        }

    }

}