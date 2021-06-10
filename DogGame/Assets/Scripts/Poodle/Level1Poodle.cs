using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DogGame.Poodle
{
    class Level1Poodle : BasePoodle
    {
        public float speed;
        Direction FirstDirection;
        Direction SecondDirection;

        
        private void Update()
        {
            Move(speed);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "ChangePoint1")
           {
                Debug.Log("FirstPoint");
                var directionSend = new DirectionSend();
                FirstDirection = directionSend.SendDirection("First");
                Jump(FirstDirection);
           }
           if (other.gameObject.tag == "ChangePoint2")
           {
                Debug.Log("SecondPoint");
                var directionSend = new DirectionSend();
                SecondDirection = directionSend.SendDirection("Second");
                Jump(SecondDirection);
           }
        }

        public override void Jump(Direction dire)
        {
            if(dire == Direction.right)
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


