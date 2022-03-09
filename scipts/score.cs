using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        double score=player.position.z/5;
        scoreText.text=score.ToString("0");
    }

   
}
