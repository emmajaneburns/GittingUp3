using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GittingUp3 : MonoBehaviour
{
   public AudioSource back; 
}

void Start (){

back = GetComponent<AudioSource>();
back.Play();





}
