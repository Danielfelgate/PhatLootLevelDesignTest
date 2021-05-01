using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMove : MonoBehaviour
{
    public int sceneToLoad;
    public Transform[] positions;
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            index = (index + 1) % positions.Length;
            transform.position = positions[index].position;
            transform.rotation = positions[index].rotation;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
