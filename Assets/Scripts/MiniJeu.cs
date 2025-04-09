using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MiniJeu : MonoBehaviour
{
    public float pointageTemps;

    [SerializeField] TextMeshProUGUI _pts;

    void Start()
    {
        pointageTemps = 0;
        InvokeRepeating("augPts", 0, 1);
    }

    void augPts()
    {
        _pts.text = "Points: " + pointageTemps.ToString("00");
    }
}
