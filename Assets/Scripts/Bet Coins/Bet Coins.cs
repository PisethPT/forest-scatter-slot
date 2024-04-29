using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Property;
using static Audios;

public class BetCoins : MonoBehaviour
{
    public void DeCrease()
    {
        audios.click.Play();
        if (property.coinsBet > 10)
        {
            property.increaseButton.enabled = true;
            property.increaseButton.GetComponent<Button>().image.color = new Color(255, 255, 255);
            property.coinsBet -= 10;
            property.credit += 10;
            property.coinBetText.text = property.coinsBet.ToString("###,###.00");
            property.creditText.text = property.credit.ToString("###,###.00");
        }
        else
        {
            property.decreaseButton.enabled = false;
            property.decreaseButton.GetComponent<Button>().image.color = Color.gray;
        }
    }

    public void InCrease()
    {
        audios.click.Play();
        if (property.credit >= 10)
        {
            property.decreaseButton.enabled = true;
            property.decreaseButton.GetComponent<Button>().image.color = new Color(255, 255, 255);
            property.credit -= 10;
            property.coinsBet += 10;
            property.coinBetText.text = property.coinsBet.ToString("###,###.00");
            property.creditText.text = property.credit.ToString("###,###.00");
        }
        else
        {
            property.increaseButton.enabled = false;
            property.increaseButton.GetComponent<Button>().image.color = Color.gray;
        }
    }
}
