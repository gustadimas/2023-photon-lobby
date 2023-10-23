using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class Lobby : MonoBehaviourPunCallbacks
{
    [SerializeField] InputField createRoom, joinRoom, nickName;
    [SerializeField] GameObject nickPanel, connectingPanel, errorPanel;
    [SerializeField] Text erroDetalhadoTxt;

    void Start()
    {
        //PhotonNetwork.ConnectUsingSettings();

        if (PhotonNetwork.NickName != "")
            nickPanel.SetActive(false);
    }

    public void GetNickname()
    {
        PhotonNetwork.NickName = nickName.text;
        nickPanel.SetActive(false);
    }

    public void CreateRoomBtt()
    {
        PhotonNetwork.CreateRoom(createRoom.text, new RoomOptions { MaxPlayers = 4 }, null);
    }

    public void JoinRoomBtt()
    {
        PhotonNetwork.JoinRoom(joinRoom.text, null);
    }

    //public override void OnConnectedToMaster()
    //{
    //    PhotonNetwork.JoinLobby(TypedLobby.Default);
    //}

    //public override void OnCreatedRoom()
    //{
    //    Debug.Log("Created Room: " + PhotonNetwork.CurrentRoom.Name);
    //}

    public override void OnJoinedRoom()
    {
        Debug.Log("Room Joined Success!");
        PhotonNetwork.LoadLevel(1);
        //connectingPanel.SetActive(true);
        //Invoke(nameof(JoinRoom), 3f);
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        connectingPanel.SetActive(false);
        Debug.Log("Room Failed! " + returnCode + " Message " + message);
    }

    //public override void OnDisconnected(DisconnectCause cause)
    //{
    //    Debug.LogError(cause);
    //    errorPanel.SetActive(true);
    //    erroDetalhadoTxt.text = "Error: " + cause;
    //}

    //void JoinRoom()
    //{
    //    PhotonNetwork.LoadLevel(1);
    //}
}