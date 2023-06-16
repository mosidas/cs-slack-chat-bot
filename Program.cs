using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("settings.json", optional: true, reloadOnChange: false);

var configuration = builder.Build();

try
{
    var client = new SlackClient
    (
        token:configuration["token"]??throw new Exception("token is null"),
        channel:configuration["channel"]??throw new Exception("channel is null")
    );

    //  <!channel>: mention all
    //  <@{user-id}>: mention user
    var text = """
    <!channel>
    <@{user-id}>
    :slack::slack::slack::slack:
    Hello World!!!!あいうえお漢字①
    :slack::slack::slack::slack:
    :smile:
    :fire:
    :lion_face:
    """;

    // post message
    var responseJson = await client.PostMessageAsync(text);
    if(responseJson is null)
    {
        throw new Exception("responseJson is null");
    }
    if(!responseJson.Ok)
    {
        throw new Exception($"responseJson.Ok:{responseJson.Ok}  responseJson.Error:{responseJson.Error}");
    }
    else
    {
        Console.WriteLine(responseJson.Ok);
    }
    // replay message
    // var tmp = await client.ReplayMessageAsync("Replay", responseJson.ts);

    // // upload file
    // var file = new FileInfo(@"C:\tmp0\genba-neko.png");
    // var res = await client.UploadFileAsync(file, text);
    // if(res is null)
    // {
    //     throw new Exception("responseJson is null");
    // }
    // Console.WriteLine(res.Ok);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


