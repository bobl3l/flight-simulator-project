using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject player;
    public GameObject explosion;

    public void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Bruh");
            movement.enabled=false;
            player.SetActive(false);
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position=transform.position;
            explosion.SetActive(true);
            FindObjectOfType<GameOver>().EndGame();
            FindObjectOfType<AudioManager>().Stop("Bgm");
            Invoke("GG",0.9f);
            FindObjectOfType<AudioManager>().Play("explosion");            
        }
    }

    void GG () {
        FindObjectOfType<AudioManager>().Play("GG");
    }
}
