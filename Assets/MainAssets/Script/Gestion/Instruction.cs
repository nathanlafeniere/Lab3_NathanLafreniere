using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtInstruction = default;
    


    void Start()
    {
        _txtInstruction.text = InstructionDepart();
    }

    public string InstructionDepart()
    {
        return "*** Course à obstacle" + "\r\n" +
        "Le but du jeu est d'atteindre la zone " + "\r\n" + "d'arrivée le plus rapidement possible" + "\r\n" +
        "Pour y arriver vous avez" + "\r\n" + " besion de trouver une clé caché ou" + "\r\n" + 
        " juste éviter les obstacles" + "\r\n" +
        "Chaque contact avec" + "\r\n" + " un obstacle entraînera une pénalité";
    }

}
