using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DogGame.Poodle
{
    public class DirectionSend
    {
        private DirectionChangeButton DirectionChangeButtonSc;

        public Direction SendDirection(string dire)
        {
            DirectionChangeButtonSc = GameObject.Find("DireChangeButtonManager").GetComponent<DirectionChangeButton>();
            if(dire == "First")
            {
                //Debug.Log(DirectionChangeButtonSc.FirstDirection);
                return DirectionChangeButtonSc.FirstDirection;
            }
            else if(dire == "Second")
            {
                return DirectionChangeButtonSc.SecondDirection;
            }
            else
            {
                Debug.Log("Buttonの数があってないよ");
                return DirectionChangeButtonSc.FirstDirection;
            }
        }
    }
}

