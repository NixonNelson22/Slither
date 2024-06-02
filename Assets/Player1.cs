using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject goal;
    Vector3 player,goalPos;
    void Start()
    {
        transform.position = new Vector3(Random.Range(-10,10),Random.Range(-5,5),0);
        goal = GameObject.Find("goal");
        goalPos = goal.transform.position;
        GPS();
    }
    void GPS (){
        Debug.Log("player1 co-ordinate" + player.x +","+ player.y );
        Debug.Log("goal co-ordinate" +  goalPos.x + ","+ goalPos.y);
    }
    void DistanceOFplayerfromGoal(){
        int playerdistanceX =(int)(player.x-goalPos.x);
        int playerdistanceY =(int)(player.y-goalPos.y);
        Debug.Log("player1 distance from goal: "+playerdistanceX+","+ playerdistanceY);
        if(playerdistanceX==0 && playerdistanceY==0){
            Debug.Log("player1 reached the goal");
        }
    }
    void Playermove(){
        if(Input.GetKeyDown(KeyCode.UpArrow)){
                    player.y ++;
                    Debug.Log("up"+player.y);
                } 
                if(Input.GetKeyDown(KeyCode.DownArrow)){
                    player.y --;
                    Debug.Log("down"+player.y);
                }
                if(Input.GetKeyDown(KeyCode.LeftArrow)){
                    player.x --;
                    Debug.Log("left"+player.x);
                }
                if(Input.GetKeyDown(KeyCode.RightArrow)){
                    player.x ++;
                    Debug.Log("right"+player.x);
                }
                transform.position = player;
    }
    // Update is called once per frame
    void Update()
    {
        GPS();
        DistanceOFplayerfromGoal();
        Playermove();
    }
}
