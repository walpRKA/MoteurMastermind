using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class SoldierScript : MonoBehaviour
{
    Animator animator;
    float speed = 0.0f;
    float attack = 0.0f;
    float Idle = 0.0f;
    bool SwitchIdle = true;


    // Start is called before the first frame update


    // Update is called once per frame

    void Update()
    {
        animator = GetComponent<Animator>();
        


        if (Input.GetKey(KeyCode.I))
        {

            speed += Time.deltaTime;

        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            speed = 0.0f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Jump());
        }


        IEnumerator Jump()
        {
            attack = 1;
            yield return new WaitForSeconds(1.2f);
            attack = 0;

        }



        animator.SetFloat("runParameter", speed);
        animator.SetFloat("Jump", attack);
        animator.SetFloat("IdleType", Idle);






    }
    void Start()
    {
        InvokeRepeating(nameof(ChangeIdle), 0f, 2f);
        
    }
    void ChangeIdle()
    {
        if (SwitchIdle == true)
        {
            Idle = 0;
            SwitchIdle = false;

        }
        else

        { 
            Idle = 1;
            SwitchIdle = true;
        }

    }
}
