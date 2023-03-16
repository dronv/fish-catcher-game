using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public int score;
    public GameObject score_UI;
    Text score_text;

    void Start()
    {
        score_text = score_UI.GetComponent <Text>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "GameObject")
        {
            score = score + 10;
            score_text.text = score.ToString();
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Bomb")
        {

        }
    }
}
