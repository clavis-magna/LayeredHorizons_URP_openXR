using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreatePlane : MonoBehaviour
{

    [Header("Plane GameObject")]
    public GameObject Plane;

    //holders for map scale set in initiateWorldScale
    private int scaleX;
    private int scaleY;

    // Start is called before the first frame update
    void Start()
    {
        scaleX = (int)InitiateWorldScale.mapScale.x;
        scaleY = (int)InitiateWorldScale.mapScale.y;

        //Call the create world to instantiate a plane
        createWorld();
    }

    private void createWorld()
    {
        //because of plane importing from blender the scaling and sides are a bit messed up so this is adjusted to account for that.
        GameObject worldPlane = Instantiate(Plane, new Vector3(0f, 0f, 0f), Quaternion.Euler(-90, 0, 0));
        worldPlane.transform.localScale = new Vector3(scaleY, scaleX, 1);
    }
}
