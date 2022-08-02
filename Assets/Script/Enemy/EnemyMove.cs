using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private Transform[] pos;
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    private float timeDelay;
    [SerializeField]
    private float startTime;
    private int i = 0;
    private Vector3 actualPos;
    [SerializeField]
    private float timeDelaymove;
    [SerializeField]
    private float duration;
    private bool facingright = true;
    // Start is called before the first frame update
    void Start()
    {
        timeDelay = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Checkmoving());
        transform.position = Vector3.MoveTowards(transform.position, pos[i].transform.position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, pos[i].transform.position) < 0.1f)
        {
            if (pos[i] != pos[pos.Length - 1])
            {
                i++;
            }
            else
            {
                i = 0;
            }
            timeDelay = startTime;
        }
        else
        {
            timeDelay -= Time.deltaTime;
        }
    }
    IEnumerator Checkmoving()
    {
        actualPos = transform.position;
        yield return new WaitForSeconds(timeDelaymove);
        if ( transform.position.z > actualPos.z)
        {
            transform.DORotate(new Vector3(0f, 0f, 0f), duration, RotateMode.Fast);
          
        }
        else if (transform.position.z < actualPos.z)
        {
           
            transform.DORotate(new Vector3(0f, 180f, 0f), duration, RotateMode.Fast);
        }

    }

}