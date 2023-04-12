using UnityEngine;
using UnityEngine.UI;
 public enum Artefakt
    {
        Schere,
        Stein,
        Papier
    }
public class Manager : MonoBehaviour
{
    [SerializeField] private Image computer, player;
    public GameObject computerWon;
    public GameObject playerWon;
    public GameObject keinerWon;
    public int round = 0;
    public Artefakt artefakt;
    public int computerScore;
    public int playerScore;
    public GameObject gesamtWinComputer;
    public GameObject gesamtWinPlayer;

    public void Playgame()
    {
        computer.GetComponent<Image>().color = Color.red;
        player.color = Color.blue;

        int rnd = Random.Range(0, 3);
        int rndP = Random.Range(0, 3);
        if(rnd == 0)
        {
            computer.color = Color.red;
        }

        if (rnd == 1)
        {
            computer.color = Color.green;
        }

        if (rnd == 2)
        {
            computer.color = Color.blue;
        }

        if (rndP == 0)
        {
            player.color = Color.red;
        }

        if (rndP == 1)
        {
            player.color = Color.green;
        }

        if (rndP == 2)
        {
            player.color = Color.blue;
        }

        if (playerWon == true)
        {
            computerWon.SetActive(false);
            keinerWon.SetActive(false);
        }

        if (computerWon == true)
        {
            keinerWon.SetActive(false);
            playerWon.SetActive(false);
        }

        if (keinerWon == true)
        {
            playerWon.SetActive(false);
            computerWon.SetActive(false);
        }

        if (computer.color == player.color)
        {
            keinerWon.SetActive(true);
        }
        else if (computer.color == Color.red && player.color == Color.green ||
                 computer.color == Color.blue && player.color == Color.red ||
                 computer.color == Color.green && player.color == Color.blue)
        {
            playerWon.SetActive(true);
            playerScore++;
        }
        else
        {
            computerWon.SetActive(true);
            computerScore++;
        }

        if (playerScore == 5)
        {
            gesamtWinPlayer.SetActive(true);
        }
        if (computerScore == 5)
        {
            gesamtWinComputer.SetActive(true);
        }

    }
}
