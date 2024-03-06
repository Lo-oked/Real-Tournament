using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public TMP_Text waveText;
    
    public async void AnnounceWave()
    {
        waveText.text = "Wave started!";
        await new WaitForSeconds(2f);
        waveText.text = "";
        
    }
}