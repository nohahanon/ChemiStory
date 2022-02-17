using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inSynGM : MonoBehaviour
{
    private string scene;
    // Start is called before the first frame update
    void Start()
    {
        scene=gameObject.scene.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick(){
        if(scene.Equals("test_synthesis"))SceneManager.LoadScene("Scenes/test/test_synsyn");
        else if(scene.Equals("test_synsyn"))SceneManager.LoadScene("Scenes/test/test_synthesis");
    }
}
