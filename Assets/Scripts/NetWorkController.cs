using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NetWorkController : MonoBehaviourPunCallbacks
{

    [SerializeField] GameObject erroPanel, conectadoPanel;
    [SerializeField] Text erroDetalhadoTxt;
    //[SerializeField] InputField nomeDaSalaInput;

    private void Start()
    {
        //nomeDaSalaInput = GetComponent<InputField>();    
    }

    public void ConnectBtt()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.LogError(cause);
        erroPanel.SetActive(true);
        erroDetalhadoTxt.text = "Error: " + cause;
    }

    public void Reiniciar()
    {
        erroPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public override void OnJoinedLobby()
    {
        conectadoPanel.SetActive(true);
        Invoke(nameof(ConnectedLoad), 7f);
    }

    void ConnectedLoad()
    {
        SceneManager.LoadScene("ServerGame");
        //conectadoPanel.SetActive(false);
    }
}