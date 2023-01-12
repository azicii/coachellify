using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

public class CoachellaArtistFinder : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI spotifyPlaylistLink;

    private string playlist_id;
    private string _nextLink;

    List<string> playlistArtists = new List<string>();

    public void FindArtists()
    {
        string[] url_parts = spotifyPlaylistLink.text.Split('/', '?');
        playlist_id = url_parts[4];

        //Try this alternate playlist with only 4 songs (3 artists) to test that length of artists is accurate
        //playlist_id = "10dOz4Ujkt66rlqL3BNEAq"

        StartCoroutine(GetArtists(playlist_id, "https://coachellify.glitch.me/getArtists"));
    }

    IEnumerator GetArtists(string playlist_id, string _nextLink)
    {
        // GET
        if (string.IsNullOrEmpty(_nextLink))
        {
            Debug.Log("We have reached the end of the playlist!");
            //foreach (var artist in playlistArtists)
            //{
            //    Debug.Log(artist);
            //}
            //yield break;
        }
        else
        {
            var getRequest = CreateRequest($"{_nextLink}?playlist_ID={playlist_id}");


            //Attachheader(getRequest, "Authorization", "Bearer BQDMtLnOOTbuKKoPiXwB3NZlbrIbWTOWx5RMXdUzPiKMHB-iVnqwRvX98FhsJwZa-FeieNSMsMYA12VFioZNCV3W4R9-9sSR65Zzw_ltJhxwgxQx_d9TYmkDZBs40S1g1HdIGiWQwgVTvAwV0hlLQW38ucQZFRRyhsYtaV2bcN0GmOpBpC8C_A");

            yield return getRequest.SendWebRequest();

            Debug.Log(getRequest.downloadHandler.text);

            //DeserializeJson(getRequest);
        }
    }

    void DeserializeJson(UnityWebRequest getRequest)
    {
        artistlist _artists = CreateFromJSON(getRequest.downloadHandler.text);

        //Debug.Log("Songs loaded: " + _artists.items.Length);
        //Debug.Log("Track 1 has: " + _artists.items[0].track.artists.Length + " artists");


        //Add all artist names to new artist list
        foreach (var track in _artists.items)
        {
            foreach (var name in track.track.artists)
            {
                if (!playlistArtists.Contains(name.name))
                {
                    playlistArtists.Add(name.name);
                }
            }
        }
        Debug.Log(playlistArtists.Count);
        Debug.Log(_artists.next);

        _nextLink = _artists.next;
        StartCoroutine(GetArtists(playlist_id, _nextLink));

        //foreach (var artist in playlistArtists)
        //{
        //    Debug.Log(artist);
        //}
    }

    UnityWebRequest CreateRequest(string path, RequestType type = RequestType.GET)
    {
        var request = new UnityWebRequest(path, type.ToString());

        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        return request;
    }

    public static artistlist CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<artistlist>(jsonString);
    }

    void Attachheader(UnityWebRequest request, string key, string value)
    {
        request.SetRequestHeader(key, value);
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

//need a new oath token every couple minutes. Need to figure out way to generate a new oath token whenever the user is using the app. 

//parsing spotify playlist links to get playlist ID

//configure this code to work for my node.js server on glitch.com

//curl - X "GET" "https://api.spotify.com/v1/playlists/1x0hY7Qnq1Fp6M7uugDcSy/tracks?fields=next%2Citems(track(artists(name)))" - H "Accept: application/json" - H "Content-Type: application/json" - H "Authorization: Bearer BQCIAClkav26czcOthX1bJAK7hDmY356AYZ24om2c-tF_wcsvELcRKahYka1bqG4__4_uEbOru1iPBjKgQaKJYW4peMJ8vu5WWGbFbkMzxJHH3_HC7lWbLFRLgE_UKhIE0dbiXG3L81BCTuabqGkl-ys4rAVulCaRewvAqu9VH48c2XGXohNzQ"

//    curl - X "GET" "https://api.spotify.com/v1/playlists/1x0hY7Qnq1Fp6M7uugDcSy/tracks?offset=100&limit=100&fields=next,items(track(artists(name)))" - H "Accept: application/json" - H "Content-Type: application/json" - H "Authorization: Bearer BQCIAClkav26czcOthX1bJAK7hDmY356AYZ24om2c-tF_wcsvELcRKahYka1bqG4__4_uEbOru1iPBjKgQaKJYW4peMJ8vu5WWGbFbkMzxJHH3_HC7lWbLFRLgE_UKhIE0dbiXG3L81BCTuabqGkl-ys4rAVulCaRewvAqu9VH48c2XGXohNzQ"

//    curl - X "GET" "https://api.spotify.com/v1/playlists/1x0hY7Qnq1Fp6M7uugDcSy/tracks?offset=200&limit=100&fields=next,items(track(artists(name)))" - H "Accept: application/json" - H "Content-Type: application/json" - H "Authorization: Bearer BQCIAClkav26czcOthX1bJAK7hDmY356AYZ24om2c-tF_wcsvELcRKahYka1bqG4__4_uEbOru1iPBjKgQaKJYW4peMJ8vu5WWGbFbkMzxJHH3_HC7lWbLFRLgE_UKhIE0dbiXG3L81BCTuabqGkl-ys4rAVulCaRewvAqu9VH48c2XGXohNzQ"

//    curl - X "GET" "https://api.spotify.com/v1/playlists/1x0hY7Qnq1Fp6M7uugDcSy/tracks?offset=300&limit=100&fields=next,items(track(artists(name)))" - H "Accept: application/json" - H "Content-Type: application/json" - H "Authorization: Bearer BQCIAClkav26czcOthX1bJAK7hDmY356AYZ24om2c-tF_wcsvELcRKahYka1bqG4__4_uEbOru1iPBjKgQaKJYW4peMJ8vu5WWGbFbkMzxJHH3_HC7lWbLFRLgE_UKhIE0dbiXG3L81BCTuabqGkl-ys4rAVulCaRewvAqu9VH48c2XGXohNzQ"

//    curl - X "GET" "https://api.spotify.com/v1/playlists/1x0hY7Qnq1Fp6M7uugDcSy/tracks?offset=400&limit=100&fields=next,items(track(artists(name)))" - H "Accept: application/json" - H "Content-Type: application/json" - H "Authorization: Bearer BQCIAClkav26czcOthX1bJAK7hDmY356AYZ24om2c-tF_wcsvELcRKahYka1bqG4__4_uEbOru1iPBjKgQaKJYW4peMJ8vu5WWGbFbkMzxJHH3_HC7lWbLFRLgE_UKhIE0dbiXG3L81BCTuabqGkl-ys4rAVulCaRewvAqu9VH48c2XGXohNzQ"

//    curl - X "GET" "https://api.spotify.com/v1/playlists/1x0hY7Qnq1Fp6M7uugDcSy/tracks?offset=500&limit=100&fields=next,items(track(artists(name)))" - H "Accept: application/json" - H "Content-Type: application/json" - H "Authorization: Bearer BQCIAClkav26czcOthX1bJAK7hDmY356AYZ24om2c-tF_wcsvELcRKahYka1bqG4__4_uEbOru1iPBjKgQaKJYW4peMJ8vu5WWGbFbkMzxJHH3_HC7lWbLFRLgE_UKhIE0dbiXG3L81BCTuabqGkl-ys4rAVulCaRewvAqu9VH48c2XGXohNzQ"