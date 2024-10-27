using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupActionScriptable : GenericActionScriptable
{
   [SerializeField]
   [TextArea(5, 8)]
   private string description;

   [SerializeField]
   private Sprite icon;

   [SerializeField]
   private Color textColor;

   [SerializeField]
   private Color backgroundColor;

   [SerializeField]
   [Range(0, 7)]
   private float timeToClosePopup;

   public override IEnumerable Execute() {
      yield return new WaitForSeconds(DelayToStart);

      // GameController -> ShowPopup
   }

}
