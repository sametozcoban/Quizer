using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayToMathLevel : MonoBehaviour
{
    [SerializeField] private int sceneIndex;

    public void MathSceneToQaScene()
    {
       
        SceneManager.LoadScene(sceneIndex);
    }
}
