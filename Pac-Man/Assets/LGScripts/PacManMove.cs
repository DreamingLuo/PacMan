using NUnit.Framework.Constraints;
using UnityEngine;

public class PacManMove : MonoBehaviour
{
    public Vector2 velocity;
    /// <summary>
    /// 吃豆人移动速度
    /// </summary>
    public float speed = 0.35f;
    /// <summary>
    /// 吃豆人下一步移动的目的地
    /// </summary>
    private Vector2 dest = Vector2.zero;

    public Rigidbody2D Rigidbody2;

    private void Start()
    {
        //吃豆人刚开始保持不动
        dest = this.transform.position;
        Rigidbody2 = GetComponent<Rigidbody2D>();
    }
    
    //跟物体有关的都放在FixedUpdate里面
    //保证跟机器性能无关
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Animator>().SetFloat("Dirx",1);
            GetComponent<Animator>().SetFloat("Diry",0);
            Rigidbody2.MovePosition((Vector2)transform.position+new Vector2(1,0)/5);
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Animator>().SetFloat("Dirx", 0);
            GetComponent<Animator>().SetFloat("Diry", 1);
            Rigidbody2.MovePosition((Vector2)transform.position + new Vector2(0, 1) / 5);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Animator>().SetFloat("Dirx", -1);
            GetComponent<Animator>().SetFloat("Diry", 0);
            Rigidbody2.MovePosition((Vector2)transform.position + new Vector2(-1, 0) / 5);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Animator>().SetFloat("Dirx", 0);
            GetComponent<Animator>().SetFloat("Diry", -1);
            Rigidbody2.MovePosition((Vector2)transform.position + new Vector2(0, -1) / 5);
        }
        
    }


    //按键移动脚本
    public void Move()
    {
       
    }

}
