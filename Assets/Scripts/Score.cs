using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;

    private void Start()
    {
        scoreText.text = "0";
    }

    void Update () {
        scoreText.text = player.position.z.ToString("0");
	}
}
