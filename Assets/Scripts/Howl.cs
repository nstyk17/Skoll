using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Howl : MonoBehaviour
{
    private AudioSource source;
    public AudioClip clip;
    private Animator anim;
    private PlayerMovement pm;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            anim.SetBool("isHowling", true);
            source.PlayOneShot(clip);
            pm.StopMoving();
            pm.enabled = false;
        }
        else if(source.isPlaying == false)
        {
            anim.SetBool("isHowling", false);
            pm.enabled = true;
        }
    }
}
