using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DogGame.Poodle
{
    abstract class BasePoodle : MonoBehaviour
    {
        protected void Move(float sp)
        {
            transform.Translate(Vector3.forward * sp * Time.deltaTime);
        }

        abstract public void Jump(Direction dire);
    }

}

