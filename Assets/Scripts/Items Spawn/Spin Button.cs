using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using static Property;
using static Audios;

public class SpinButton : SlotRules
{
    private float timeSpin = 3f;
    private float row2SubTime, row3SubTime;
    private bool isSpin = false;
    private void FixedUpdate()
    {
        if (isSpin)
        {
            timeSpin -= Time.deltaTime;
            if (timeSpin <= 0f)
            {
                property.boxCollider2Ds[0].enabled = true;
                row2SubTime = Random.Range(1.5f, 2.5f);
                StartCoroutine(Row2Stop(row2SubTime));
                isSpin = false;
            }
        }

    }

    private IEnumerator Row2Stop(float time)
    {
        yield return new WaitForSeconds(time);
        property.boxCollider2Ds[1].enabled = true;
        row3SubTime = Random.Range(1.5f, 2.5f);
        yield return new WaitForSeconds(row3SubTime);
        property.boxCollider2Ds[2].enabled = true;
        yield return new WaitForSeconds(.5f);
        // isSpin = false;
        timeSpin = 3f;
        row2SubTime = 0;
        row3SubTime = 0;
        EnableCheckRows(true);
        yield return new WaitForSeconds(.5f);
        GetSlotRules();
        transform.GetComponent<Button>().enabled = true;
        transform.GetComponent<Button>().image.color = new Color(255, 255, 255);

        property.increaseButton.enabled = true;
        property.increaseButton.GetComponent<Button>().image.color = new Color(255, 255, 255);
        property.decreaseButton.enabled = true;
        property.decreaseButton.GetComponent<Button>().image.color = new Color(255, 255, 255);

        // clear coins
        property.coinsBet = 0;
        property.coinBetText.text = property.coinsBet.ToString("0.00");
    }

    public async void Spin()
    {
        audios.spin.Play();
        property.increaseButton.enabled = false;
        property.increaseButton.GetComponent<Button>().image.color = Color.gray;
        property.decreaseButton.enabled = false;
        property.decreaseButton.GetComponent<Button>().image.color = Color.gray;

        transform.GetComponent<Button>().enabled = false;
        transform.GetComponent<Button>().image.color = Color.gray;

        ClearString();
        EnableCheckRows(false);
        property.boxCollider2Ds[0].enabled = false;
        property.boxCollider2Ds[1].enabled = false;
        property.boxCollider2Ds[2].enabled = false;
        await Task.Delay(4000);
        isSpin = true;
    }

    private void EnableCheckRows(bool isEnable)
    {
        foreach (var rowCheck in property.rowsCheckBoxCollider2Ds)
        {
            rowCheck.enabled = isEnable;
        }
    }

    private void ClearString()
    {
        _row1column1 = string.Empty;
        _row1column2 = string.Empty;
        _row1column3 = string.Empty;
        _row2column1 = string.Empty;
        _row2column2 = string.Empty;
        _row2column3 = string.Empty;
        _row3column1 = string.Empty;
        _row3column2 = string.Empty;
        _row3column3 = string.Empty;

    }
}
