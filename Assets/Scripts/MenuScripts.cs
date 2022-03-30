using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScripts : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScence(string nameScence)
    {
        SceneManager.LoadScene(nameScence, LoadSceneMode.Single);
    }
}
