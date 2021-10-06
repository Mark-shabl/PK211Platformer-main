using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. UI;

public class tepMove : MonoBehaviour
{
    public CharacterController2D controller;
    float hMove = 0f;
    float speed = 25f;
    bool jump = false;

    private int bottleCount;
    private int BananaCont;
    public Text  ScoreText;
    public Text  ScoreText1;
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score:" + bottleCount.ToString();
        ScoreText1.text = "Score:" + BananaCont.ToString();
        hMove = Input.GetAxisRaw("Horizontal")*speed;
        if (Input.GetButtonDown("Jump") )
        {
            jump = true;
        }
    }
    private void FixedUpdate()
    {
        controller.Move(hMove*Time.fixedDeltaTime,false,jump);
        jump = false;
    }
    public void bottleAdd()
    {
        bottleCount += 1;
    }
    public void BananaAdd()
    {
        BananaCont += 3;
    }

}