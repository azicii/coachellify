using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using System;

public class CoachellaArtistFinder : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI spotifyPlaylistLink;
    [SerializeField] TextMeshProUGUI artistsAtCoachella;

    string playlist_id;

    public List<string> playlistArtists = new List<string>();

    List<string> matchingArtists = new List<string>();

    public void FindArtists()
    {
        //Parse spotify playlist URL for playlist ID
        Uri myUri = new Uri(spotifyPlaylistLink.text);
        string[] pathSegments = myUri.Segments;

        playlist_id = pathSegments[2];
        Debug.Log($"Playlist ID: {playlist_id}");


        StartCoroutine(GetArtists(playlist_id, "https://coachellify.glitch.me/getArtists"));
    }

    //GET
    IEnumerator GetArtists(string playlist_id, string URI)
    {
        
        var getRequest = CreateRequest($"{URI}?playlist_ID={playlist_id}");

        yield return getRequest.SendWebRequest();

        //Debug.Log(getRequest.downloadHandler.text);

        DeserializeJson(getRequest);
    }
    UnityWebRequest CreateRequest(string path, RequestType type = RequestType.GET)
    {
        var request = new UnityWebRequest(path, type.ToString());

        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        return request;
    }

    void DeserializeJson(UnityWebRequest getRequest)
    {
        artistlist _artists = CreateFromJSON(getRequest.downloadHandler.text);

        //Add all artist names to new artist list
        foreach (var track in _artists.body.items)
        {
            foreach (var name in track.track.artists)
            {
                if (!playlistArtists.Contains(name.name))
                {
                    playlistArtists.Add(name.name);
                }
            }
        }

        Debug.Log($"Playlist has {playlistArtists.Count} artists!");

        MatchArtists(playlistArtists);
    }

    public static artistlist CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<artistlist>(jsonString);
    }

    void MatchArtists(List<string> _playlistArtists)
    {
        List<string> _coachellaArtists = FindObjectOfType<CoachellaLineup>().coachellaArtists;

        foreach (string artist in _playlistArtists)
        {
            if (_coachellaArtists.Contains(artist))
            {
                matchingArtists.Add(artist);
            }
        }

        string allArtists = "";

        Debug.Log("The following artists from your playlist will be at Coachella 2023!");
        foreach (string artist in matchingArtists)
        {
            allArtists = allArtists + ", " + artist;
        }

        artistsAtCoachella.text = allArtists.Remove(0, 2);
    }

    public enum RequestType
    {
        GET,
        POST,
        PUT,
    }

    [System.Serializable]
    public class artistlist
    {
        public body body;
    }

    [System.Serializable] 
    public class body
    {
        public items[] items;
        public string next;
    }

    [System.Serializable]
    public class items
    {
        public track track;
    }

    [System.Serializable]
    public class track
    {
        public artists[] artists;
    }

    [System.Serializable]
    public class artists
    {
        public string name;
    }
}
