using UnityEngine;

namespace DogGame.Poodle
{
    public class DirectionChangeButton : MonoBehaviour
    {
        //初期値は右
        public Direction FirstDirection, SecondDirection = Direction.right;


        public void FirstChange()
        {
            if (FirstDirection == Direction.right)
            {
                FirstDirection = Direction.left;
            }
            else
            {
                FirstDirection = Direction.right;
            }
        }
        public void SecondChange()
        {
            if (SecondDirection == Direction.right)
            {
                SecondDirection = Direction.left;
            }
            else
            {
                SecondDirection = Direction.right;
            }
        }

    }
}