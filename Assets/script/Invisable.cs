using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisable : MonoBehaviour
{
    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        Color color = sprite.material.color;
        color.a = 0f;
        sprite.material.color = color;

    }
    IEnumerator InvisableSprite()
    {
        for(float f = 0.2f; f<=1; f+=0.2f)
        {
            Color color = sprite.material.color;
            color.a = f;
            sprite.material.color = color;
            yield return new WaitForSeconds(0.05f);
        }
    }
    public void StartInvisable()
    {
        StartCoroutine("InvisableSprite");
    }
}
