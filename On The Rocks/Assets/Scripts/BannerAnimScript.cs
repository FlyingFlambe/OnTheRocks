using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BannerAnimScript : MonoBehaviour {

    public Animator anim;
    GameControllerScript game;

	void Start () {
        anim = GetComponent<Animator>();
        game = FindObjectOfType<GameControllerScript>();

        anim.SetBool("EnableGameplay", false);
    }
}
