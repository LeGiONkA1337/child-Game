using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fading : MonoBehaviour
{
    SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        Color color = sprite.material.color;
        color.a = 0f;
        sprite.material.color = color;

    }
    IEnumerator InvisableSprite()
    {
        for (float f = 0.02f; f <= 1; f += 0.02f)
        {
            Color color = sprite.material.color;
            color.a = f;
            sprite.material.color = color;
            yield return new WaitForSeconds(0.05f);
        }
    }
    IEnumerator VisableSprite()
    {
        for (float f = 1f; f >= -0.05; f -= 0.015f)
        {
            Color color = sprite.material.color;
            color.a = f;
            sprite.material.color = color;
            yield return new WaitForSeconds(0.05f);
        }
    }
    public void StartVisable()
    {
        StartCoroutine("VisableSprite");
    }
    public void StartInvisable()
    {
        StartCoroutine("InvisableSprite");
    }
}
