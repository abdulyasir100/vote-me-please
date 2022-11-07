using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerGenerator : MonoBehaviour
{
    public Sprite[] rambut_styles;
    public Sprite[] baju_styles;
    public Sprite[] lenganAtasLeft_styles;
    public Sprite[] lenganAtasRight_styles;
    public Sprite[] celana_styles;
    public Sprite[] sepatu_styles;

    public void GenerateRandomFollower(SpriteRenderer baju_renderer, SpriteRenderer lenganAtasLeft_renderer, SpriteRenderer lenganAtasRight_renderer,
        SpriteRenderer rambut_renderer, SpriteRenderer celana_renderer, SpriteRenderer sepatu_renderer, int row)
    {
        int randomizer = Random.Range(0, rambut_styles.Length);
        rambut_renderer.sprite = rambut_styles[randomizer];
        rambut_renderer.sortingOrder += row * 10; 
        randomizer = Random.Range(0, baju_styles.Length);
        baju_renderer.sprite = baju_styles[randomizer];
        baju_renderer.sortingOrder += row * 10;
        lenganAtasLeft_renderer.sprite = lenganAtasLeft_styles[randomizer];
        lenganAtasRight_renderer.sprite = lenganAtasRight_styles[randomizer];
        lenganAtasLeft_renderer.sortingOrder += row * 10;
        lenganAtasRight_renderer.sortingOrder += row * 10;
        randomizer = Random.Range(0, celana_styles.Length);
        celana_renderer.sprite = celana_styles[randomizer];
        celana_renderer.sortingOrder += row * 10;
        randomizer = Random.Range(0, sepatu_styles.Length);
        sepatu_renderer.sprite = sepatu_styles[randomizer];
        sepatu_renderer.sortingOrder += row * 10;
    }

}
