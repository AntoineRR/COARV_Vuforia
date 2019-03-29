using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lancement_Script : MonoBehaviour
{
    public GameObject piques;
    public GameObject piege_rotatif;
    public GameObject coffre;

    // 0 = rien, 1 = piques, 2 = piège rotatif, 3 = coffre
    int[][] terrain = { new int[10]{1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                        new int[10]{1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                        new int[10]{1, 0, 1, 1, 1, 0, 1, 2, 0, 1},
                        new int[10]{1, 0, 1, 0, 0, 0, 1, 0, 0, 1},
                        new int[10]{1, 3, 2, 0, 2, 1, 1, 0, 1, 1},
                        new int[10]{1, 1, 1, 0, 0, 0, 0, 0, 1, 1},
                        new int[10]{0, 0, 0, 1, 2, 1, 1, 0, 0, 1},
                        new int[10]{0, 0, 0, 0, 0, 0, 0, 1, 0, 1},
                        new int[10]{1, 0, 0, 1, 2, 1, 0, 0, 0, 1},
                        new int[10]{1, 1, 1, 1, 1, 1, 1, 1, 1, 1}};

    // Start is called before the first frame update
    void Start()
    {
        // création du terrain
        GameObject temp;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                switch(terrain[i][j])
                {
                    case 1:
                        temp = GameObject.Instantiate(piques, gameObject.transform.parent);
                        break;
                    case 2:
                        temp = GameObject.Instantiate(piege_rotatif, gameObject.transform.parent);
                        break;
                    case 3:
                        temp = GameObject.Instantiate(coffre, gameObject.transform.parent);
                        break;
                    default:
                        temp = null;
                        break;
                }
                if(temp != null)
                    temp.transform.localPosition = new Vector3(j - 4.5f, 0, i - 4.5f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
