/// <summary>
/// Responce object from slack
/// </summary>
/// <param name="ok"></param>
/// <param name="channel"></param>
/// <param name="ts"></param>
/// <param name="message"></param>
/// <returns></returns>
public record ResponceObject(bool ok, string channel, string ts, Message message);

/// <summary>
/// Message object from slack
/// </summary>
/// <param name="bot_id"></param>
/// <param name="type"></param>
/// <param name="text"></param>
/// <param name="user"></param>
/// <param name="ts"></param>
/// <param name="team"></param>
/// <param name="bot_profile"></param>
/// <returns></returns>
public record Message(string bot_id, string type, string text, string user, string ts, string team, BotProfile bot_profile);

/// <summary>
/// Bot profile object from slack
/// </summary>
/// <param name="id"></param>
/// <param name="deleted"></param>
/// <param name="name"></param>
/// <param name="updated"></param>
/// <param name="app_id"></param>
/// <param name="icons"></param>
/// <param name="team_id"></param>
/// <returns></returns>
public record BotProfile(string id, bool deleted, string name, int updated, string app_id, Icons icons, string team_id);

/// <summary>
/// Icons object from slack
/// </summary>
/// <param name="image_36"></param>
/// <param name="image_48"></param>
/// <param name="image_72"></param>
/// <returns></returns>
public record Icons(string image_36, string image_48, string image_72);