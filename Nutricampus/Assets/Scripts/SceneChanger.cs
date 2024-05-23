using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneName; // Nombre de la escena a cargar

    public void ChangeScene()
    {
        // Cargar la escena especificada
        SceneManager.LoadScene(sceneName);
    }
}
