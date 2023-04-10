using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GestionScene : MonoBehaviour
{
    [SerializeField] private GameObject _Instruction = default;
    

    public void ChangerSceneSuivante()
    {
        int noScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(noScene+1);
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void ChargerSceneDepart()
    {
        SceneManager.LoadScene(0);
    }

    public void ChargerInstruction()
    {
        _Instruction.SetActive(true);
    }
    public void EnleverInstruction()
    {
        _Instruction.SetActive(false);
    }

    

}
