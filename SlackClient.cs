
using System.Text.Json;

public class SlackClient
{
	private readonly Uri _postMessageUri = new Uri("https://slack.com/api/chat.postMessage");
    private readonly Uri _fileUploadUri = new Uri("https://slack.com/api/files.upload");
    private readonly string _channel;
    private readonly string _token;

    /// <summary>
    /// Slack client
    /// </summary>
    /// <param name="token"></param>
    /// <param name="channel"></param>
	public SlackClient(string token, string channel)
    {
        _channel = channel;
        _token = token;
    }

    /// <summary>
    /// Post message to slack channel
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
	public async Task<ResponceObject?> PostMessageAsync(string text)
	{
		var data = new Dictionary<string, string>
        {
            { "token", _token },
            { "channel", _channel },
            { "text", text }
        };
        var content = new FormUrlEncodedContent(data);

        var client = new HttpClient();
        var response = await client.PostAsync(_postMessageUri, content);
        var responseString = await response.Content.ReadAsStringAsync();
        var responceJson = JsonSerializer.Deserialize<ResponceObject>(responseString);

        return responceJson;
	}

    /// <summary>
    /// Replay message to slack channel
    /// </summary>
    /// <param name="text"></param>
    /// <param name="ts"></param>
    /// <returns></returns>
    public async Task<ResponceObject?> ReplayMessageAsync(string text, string ts)
	{
		var data = new Dictionary<string, string>
        {
            { "token", _token },
            { "channel", _channel },
            { "text", text },
            { "thread_ts", ts }
        };
        var content = new FormUrlEncodedContent(data);

        var client = new HttpClient();
        var response = await client.PostAsync(_postMessageUri, content);
        var responseString = await response.Content.ReadAsStringAsync();
        var responceJson = JsonSerializer.Deserialize<ResponceObject>(responseString);

        return responceJson;
	}

    /// <summary>
    /// Upload file to slack channel
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public async Task<ResponceObject?> UploadFileAsync(FileInfo file)
    {
        var data = new Dictionary<string, string>
        {
            { "token", _token },
            { "channels", _channel },
            { "filename", file.Name }
        };
        var content = new MultipartFormDataContent();
        content.Add(new StreamContent(file.OpenRead()), "file", file.Name);
        foreach (var item in data)
        {
            content.Add(new StringContent(item.Value), item.Key);
        }

        var client = new HttpClient();
        var response = await client.PostAsync(_fileUploadUri, content);
        var responseString = await response.Content.ReadAsStringAsync();
        var responceJson = JsonSerializer.Deserialize<ResponceObject>(responseString);

        return responceJson;
    }
}