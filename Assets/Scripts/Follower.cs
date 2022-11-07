using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public FollowerGenerator generator;

    public SpriteRenderer baju_renderer;
    public SpriteRenderer lenganAtasLeft_renderer;
    public SpriteRenderer lenganAtasRight_renderer;
    public SpriteRenderer rambut_renderer;
    public SpriteRenderer celana_renderer;
    public SpriteRenderer sepatu_renderer;

    private Animator anim;
    private float delayAnim = 6f;
    private float counter = 0;

    private void Start()
    {
        counter = randomDelay(3f);
        anim = GetComponent<Animator>();
        int row = transform.parent.GetComponent<FollowerPhase>().row_number;
        generator.GenerateRandomFollower(baju_renderer, lenganAtasLeft_renderer, lenganAtasRight_renderer, rambut_renderer, celana_renderer, sepatu_renderer,row);
    }

    private float randomDelay(float minimum)
    {
        return Random.Range(minimum, delayAnim);
    }

    private void Update()
    {
        if (counter<=0)
        {
            anim.SetTrigger("RaiseHand");
            counter = randomDelay(4f);
        }
        else
        {
            counter -= Time.deltaTime;
        }
    }

    private void OnDisable()
    {
        Destroy(this.gameObject);
    }

}
