using System.Text.Json.Serialization;

public record ResponceFileUpload(
    [property:JsonPropertyName("ok")] bool Ok,
    [property:JsonPropertyName("file")] File File
);

public record File(
    [property:JsonPropertyName("id")] string Id,
    [property:JsonPropertyName("created")] long Created,
    [property:JsonPropertyName("timestamp")] long Timestamp,
    [property:JsonPropertyName("name")] string Name,
    [property:JsonPropertyName("title")] string Title,
    [property:JsonPropertyName("mimetype")] string Mimetype,
    [property:JsonPropertyName("filetype")] string Filetype,
    [property:JsonPropertyName("pretty_type")] string PrettyType,
    [property:JsonPropertyName("user")] string User,
    [property:JsonPropertyName("editable")] bool Editable,
    [property:JsonPropertyName("size")] int Size,
    [property:JsonPropertyName("mode")] string Mode,
    [property:JsonPropertyName("is_external")] bool IsExternal,
    [property:JsonPropertyName("external_type")] string ExternalType,
    [property:JsonPropertyName("is_public")] bool IsPublic,
    [property:JsonPropertyName("public_url_shared")] bool PublicUrlShared,
    [property:JsonPropertyName("display_as_bot")] bool DisplayAsBot,
    [property:JsonPropertyName("username")] string Username,
    [property:JsonPropertyName("url_private")] string UrlPrivate,
    [property:JsonPropertyName("url_private_download")] string UrlPrivateDownload,
    [property:JsonPropertyName("thumb_64")] string Thumb64,
    [property:JsonPropertyName("thumb_80")] string Thumb80,
    [property:JsonPropertyName("thumb_360")] string Thumb360,
    [property:JsonPropertyName("thumb_360_w")] int Thumb360W,
    [property:JsonPropertyName("thumb_360_h")] int Thumb360H,
    [property:JsonPropertyName("thumb_480")] string Thumb480,
    [property:JsonPropertyName("thumb_480_w")] int Thumb480W,
    [property:JsonPropertyName("thumb_480_h")] int Thumb480H,
    [property:JsonPropertyName("thumb_160")] string Thumb160,
    [property:JsonPropertyName("image_exif_rotation")] int ImageExifRotation,
    [property:JsonPropertyName("original_w")] int OriginalW,
    [property:JsonPropertyName("original_h")] int OriginalH,
    [property:JsonPropertyName("permalink")] string Permalink,
    [property:JsonPropertyName("permalink_public")] string PermalinkPublic,
    [property:JsonPropertyName("comments_count")] int CommentsCount,
    [property:JsonPropertyName("is_starred")] bool IsStarred,
    [property:JsonPropertyName("shares")] Shares Shares,
    [property:JsonPropertyName("channels")] List<string> Channels,
    [property:JsonPropertyName("groups")] List<string> Groups,
    [property:JsonPropertyName("ims")] List<string> Ims,
    [property:JsonPropertyName("has_rich_preview")] bool HasRichPreview
);

public record Shares(
    [property:JsonPropertyName("private")] Dictionary<string, List<PrivateShare>> Private
);

public record PrivateShare(
    [property:JsonPropertyName("reply_users")] List<string> ReplyUsers,
    [property:JsonPropertyName("reply_users_count")] int ReplyUsersCount,
    [property:JsonPropertyName("reply_count")] int ReplyCount,
    [property:JsonPropertyName("ts")] string Ts
);
