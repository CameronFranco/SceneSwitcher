using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene1 : MonoBehaviour {

    public void SwitchScenes()
    {
        SceneManager.LoadScene(2);
    }

}
