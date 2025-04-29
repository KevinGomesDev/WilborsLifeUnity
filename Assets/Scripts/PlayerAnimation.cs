using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Player player;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
         if (player.direction.sqrMagnitude > 0)
        {
            anim.SetInteger("Transition", 1);
        } else
        {
            anim.SetInteger("Transition", 0);
        }
    }
}
