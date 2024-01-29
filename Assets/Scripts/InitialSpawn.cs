using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InitialSpawn : MonoBehaviour
{

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        var player1 = PlayerInput.Instantiate(prefab, 0, "Arrows", 0, Keyboard.current);

        player1.transform.position = new Vector3(0, 0.5f, 0);

        player1.transform.parent.GetChild(1).GetComponent<Camera>().rect = new Rect(0, 0, 0, 1);

    }

}
