using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactSound : MonoBehaviour
{
    public AudioSource impactSource;
    GameObject mover;
    GameObject anchor;

    // Start is called before the first frame update
    void Start()
    {
        // teleport (DBZ sound here)
        mover.transform.position = new Vector3(0f, 0f, -1f);

        // move offset
        mover.transform.position += Vector3.up * 5f;
        

        float dist  = Vector3.Distance(mover.transform.position, anchor.transform.position);
        if (dist < 0.5f)
        {
            // do a proximity thing
            impactSource.volume = 1f - (dist/2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // every time we collide with something else, play our impact sound
    // on collsion
        // reference sound
        // hit play

    void OnCollisionEnter (Collision col)
    {
        impactSource.Play();
    }
}
