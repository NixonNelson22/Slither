
using UnityEngine;

public class Player2 : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject goal;
    Vector3 player,goalPos;
    public void Start()
    {
        transform.position = new Vector3(Random.Range(-10,10),Random.Range(-5,5),0);
        goal = GameObject.Find("goal");
        goalPos = goal.transform.position;
        player = transform.position;
        GPS();
    }
    public void GPS (){
         Debug.Log("player2 co-ordinate" + player.x + "," + player.y);
         Debug.Log("goal co-ordinate" + goalPos.x + "," + goalPos.y);
    }
    public void DistanceOFplayerfromGoal(){
        int Player2distanceX =(int)(player.x-goalPos.x);
        int Player2distanceY =(int)(player.y-goalPos.y);
        Debug.Log("player2 distance from goal: "+ Player2distanceX+","+ Player2distanceY);
        if(Player2distanceX==0 && Player2distanceY==0){
            Debug.Log("player2 reached the goal");
        }
    }
    public void Player2move(){
        if(Input.GetKeyDown(KeyCode.W)){
                    player.y ++;
                    Debug.Log("up"+player.y);
                } 
                if(Input.GetKeyDown(KeyCode.S)){
                    player.y --;
                    Debug.Log("down"+player.y);
                }
                if(Input.GetKeyDown(KeyCode.A)){
                    player.x --;
                    Debug.Log("left"+player.x);
                }
                if(Input.GetKeyDown(KeyCode.D)){
                    player.x ++;
                    Debug.Log("right"+player.x);
                }
                transform.position = player;
    }
    // Update is called once per frame
    public void Update()
    {
        GPS();
        DistanceOFplayerfromGoal();
        Player2move();
    }
}
