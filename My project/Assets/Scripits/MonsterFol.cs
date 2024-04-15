using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MonsterFol : MonoBehaviour
{
    private Transform player;  
    public LayerMask PlayerLay;
    
    public float fov=100f;                             //поле зрения
    public float speed;                           //скорость передвижения
    public float attackRange = 1.5f;              //радиус атаки

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, player.position) < fov)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            
        }
        
        if (Vector2.Distance(transform.position, player.position) < attackRange)
        {
            Kill();
        }
    }

    public void Kill()
    {
        SceneManager.LoadScene("Cast_scene");
    }
}
