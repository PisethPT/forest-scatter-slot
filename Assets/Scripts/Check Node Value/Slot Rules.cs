using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Property;
using static Audios;

public class SlotRules : CheckWin
{
   public void GetSlotRules()
   {
      // rule (-)
      if (_row1column1 == _row1column2 && _row1column2 == _row1column3)
      {
         audios.win.Play();
         GetNodeFromRows(_row1column1, _row1column2, _row1column3);
         GetCoinsWin();
      }
      if (_row2column1 == _row2column2 && _row2column2 == _row2column3)
      {
         audios.win.Play();
         GetNodeFromRows(_row2column1, _row2column2, _row2column3);
         GetCoinsWin();
      }
      if (_row3column1 == _row3column2 && _row3column2 == _row3column3)
      {
         audios.win.Play();
         GetNodeFromRows(_row3column1, _row3column2, _row3column3);
         GetCoinsWin();
      }

      // role (X)
      if (_row1column1 == _row2column2 && _row2column2 == _row3column3)
      {
         audios.win.Play();
         GetNodeFromRows(_row1column1, _row2column2, _row3column3);
         GetCoinsWin();
      }
      if (_row1column3 == _row2column2 && _row2column2 == _row3column1)
      {
         audios.win.Play();
         GetNodeFromRows(_row1column3, _row2column2, _row3column1);
         GetCoinsWin();
      }

      // role (V & ^)
      if (_row1column1 == _row2column2 && _row2column2 == _row1column3)
      {
         audios.win.Play();
         GetNodeFromRows(_row1column1, _row2column2, _row1column3);
         GetCoinsWin();
      }
      if (_row3column1 == _row2column2 && _row2column2 == _row3column3)
      {
         audios.win.Play();
         GetNodeFromRows(_row3column1, _row2column2, _row3column3);
         GetCoinsWin();
      }
      if (_row1column2 == _row2column2 && _row2column2 == _row3column2)
      {
         audios.win.Play();
         GetNodeFromRows(_row1column2, _row2column2, _row3column2);
         GetCoinsWin();
      }if (_row1column2 == _row2column1 && _row2column1 == _row3column2)
      {
         audios.win.Play();
         GetNodeFromRows(_row1column2, _row2column1, _row3column2);
         GetCoinsWin();
      }

   }

   internal void GetCoinsWin()
   {

      if (property.coinsBet > 0)
      {
         audios.click.Play();
         int coins = property.coinsBet * 2;
         property.coinsWin += coins;
         property.credit += coins;
         property.creditText.text = property.credit.ToString("###,###.00");
         property.coinsWinText.text = property.coinsWin.ToString("###,###.00");
         property.coinBetText.text = "0.00";
         property.coinsBet = 0;
      }
   }
}
