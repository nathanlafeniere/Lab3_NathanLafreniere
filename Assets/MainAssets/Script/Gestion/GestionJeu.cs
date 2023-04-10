using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionJeu : MonoBehaviour
{
    
    //Attribut
    private int _pointage;
    private float _time = 0;
    private float _tempsFinal = 0;
    private FinNiveau _end;
    


    //Methode private
    private void Awake()
    {
        // Vérifie si un gameObject GestionJeu est déjà présent sur la scène si oui
        // on détruit celui qui vient d'être ajouté. Sinon on le conserve pour le 
        // scène suivante.
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    private void Start()
    {
        _time = Time.time;
    }

    

    // Update is called once per frame
    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4 || SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(gameObject);
        }
    }

    
    
    public void AugmenterCollision()
    {
        _pointage++;
        //Debug.Log("Nombre d'accrochages : " + _pointage);
        UIManager _UIManager = FindObjectOfType<UIManager>();
        _UIManager.ChangerPointage(_pointage);
    }

    //methode public
 
    public int GetPointage()
    {
         return _pointage;
    }

    public float GetTemps()
    {
        return _time;
    }


    public void SetTempsFinal(float _temps)
    {
        _tempsFinal = _temps - _time;
    }

    public float GetTempsFinal()
    {
        return _tempsFinal;
    }
}
