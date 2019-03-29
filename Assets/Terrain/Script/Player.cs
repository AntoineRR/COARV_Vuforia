using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        // si on touche un piège, le snowman sur le plan du terrain est désactivé (il disparaît.
        for(int i = 0; i < gameObject.transform.parent.childCount; i++)
            gameObject.transform.parent.GetChild(i).gameObject.SetActive(false);
    }
}
