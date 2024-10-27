using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManagerEvent
{
   // Script de disparo de eventos

   public delegate void SendActionList(List<GenericActionScriptable> actionList);
   public static event SendActionList SendActionListEvent;

   public void DispatchAllGenericActionListEvent(List<GenericActionScriptable> actionList) {
      //if (SendActionListEvent != null) {
      //   SendActionListEvent(actionList);
      //}
      // mesma coisa que o codigo acima, apenas mais simplificado
      SendActionListEvent?.Invoke(actionList);
   }
}
