using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DogGame.Poodle
{
    abstract class PoodleMover : MonoBehaviour
    {
        protected void Move(float sp)
        {
            transform.Translate(Vector3.forward * sp * Time.deltaTime);
        }

        protected void Jump(Direction dire)
        {
            if (dire == Direction.right)
            {
                //右に飛ぶ処理
                Debug.Log("右に飛ぶ");
            }
            else
            {
                //左に飛ぶ処理
                Debug.Log("左に飛ぶ");
            }
        }
    }

}

