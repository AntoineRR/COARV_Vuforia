using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSphereTerrain : MonoBehaviour
{
    public GameObject player;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // on lance un rayon depuis la caméra vers le marqueur du snowman.
        Vector3 direction = player.transform.position - camera.transform.position;
        Vector3 origin = camera.transform.position;
        Ray r = new Ray(origin, direction);

        // on calcul l'intersection avec le plan du terrain et on déplace le second snowman sur ce point.
        Plane p = new Plane(gameObject.transform.parent.up, gameObject.transform.parent.position);
        float t = 0.0f;
        if (p.Raycast(r, out t))
            gameObject.transform.position = r.GetPoint(t);

        // si l'on ressort du terrain, le snowman réapparaît.
        if (gameObject.transform.localPosition.x > 5.0f || gameObject.transform.localPosition.x < -5.0f ||
            gameObject.transform.localPosition.y > 5.0f || gameObject.transform.localPosition.y < -5.0f)
        {
            for (int i = 0; i < gameObject.transform.childCount; i++)
                gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
