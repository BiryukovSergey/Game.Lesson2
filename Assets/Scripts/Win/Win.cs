using System;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
   public Text Text;
   public Canvas Canvas;


   private void Awake()
   {
      Canvas.gameObject.SetActive(false);
   }

   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Player"))
      {
         Canvas.gameObject.SetActive(true);
          Text.text = "You WIN!";
      }
   }
}
