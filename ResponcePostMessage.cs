using System.Text.Json.Serialization;

/// <summary>
/// Responce object from slack
/// </summary>
/// <param name="Ok"></param>
/// <param name="Channel"></param>
/// <param name="Ts"></param>
/// <param name="Message"></param>
/// <returns></returns>
public record ResponcePostMessage(
    [property:JsonPropertyName("ok")] bool Ok,
    [property:JsonPropertyName("channel")] string Channel,
    [property:JsonPropertyName("ts")] string Ts,
    [property:JsonPropertyName("message")] Message Message,
    [property:JsonPropertyName("error")] string Error);

/// <summary>
/// Message object from slack
/// </summary>
/// <param name="BotId"></param>
/// <param name="Type"></param>
/// <param name="Text"></param>
/// <param name="User"></param>
/// <param name="Ts"></param>
/// <param name="Team"></param>
/// <param name="BotProfile"></param>
/// <returns></returns>
public record Message(
    [property:JsonPropertyName("bot_id")] string BotId,
    [property:JsonPropertyName("type")] string Type,
    [property:JsonPropertyName("text")] string Text,
    [property:JsonPropertyName("user")] string User,
    [property:JsonPropertyName("ts")] string Ts,
    [property:JsonPropertyName("team")] string Team,
    [property:JsonPropertyName("bot_profile")] BotProfile BotProfile);

/// <summary>
/// Bot profile object from slack
/// </summary>
/// <param name="Id"></param>
/// <param name="Deleted"></param>
/// <param name="Name"></param>
/// <param name="Updated"></param>
/// <param name="AppId"></param>
/// <param name="Icons"></param>
/// <param name="TeamId"></param>
/// <returns></returns>
public record BotProfile(
    [property:JsonPropertyName("id")] string Id,
    [property:JsonPropertyName("deleted")] bool Deleted,
    [property:JsonPropertyName("name")] string Name,
    [property:JsonPropertyName("updated")] int Updated,
    [property:JsonPropertyName("app_id")] string AppId,
    [property:JsonPropertyName("icons")] Icons Icons,
    [property:JsonPropertyName("team_id")] string TeamId);

/// <summary>
/// Icons object from slack
/// </summary>
/// <param name="Image36"></param>
/// <param name="Image48"></param>
/// <param name="Image72"></param>
/// <returns></returns>
public record Icons(
    [property:JsonPropertyName("image_36")] string Image36,
    [property:JsonPropertyName("image_48")] string Image48,
    [property:JsonPropertyName("image_72")] string Image72);