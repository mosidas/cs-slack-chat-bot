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

    var text = """
    Hello World!!!!
    cmwcowo
    cowmcpkewlpdlwpll@#%$^&*()_+{}|:"<>?~`1234567890-=\][;/.,':smile:
    :fire:
    :lion_face:
    """;

    // post message
    var responseJson = await client.PostMessageAsync(text);
    if(responseJson is null)
    {
        throw new Exception("responseJson is null");
    }
    if(!responseJson.ok)
    {
        throw new Exception("responseJson.ok is false");
    }
    // replay message
    // var tmp = await client.ReplayMessageAsync("Replay", responseJson.ts);

    // upload file
    // var file = new FileInfo(@"C:\tmp0\fmtoks\genba-neko.png");
    // responseJson = await client.UploadFileAsync(file);
    // if(responseJson is null)
    // {
    //     throw new Exception("responseJson is null");
    // }
    Console.WriteLine(responseJson.ok);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


