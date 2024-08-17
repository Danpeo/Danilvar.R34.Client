namespace Danilvar.R34.Client

open Newtonsoft.Json

type Post =
  { [<JsonProperty("preview_url")>]
    PreviewUrl: string

    [<JsonProperty("sample_url")>]
    SampleUrl: string

    [<JsonProperty("file_url")>]
    FileUrl: string

    [<JsonProperty("directory")>]
    Directory: int

    [<JsonProperty("hash")>]
    Hash: string

    [<JsonProperty("width")>]
    Width: int

    [<JsonProperty("height")>]
    Height: int

    [<JsonProperty("id")>]
    Id: int

    [<JsonProperty("image")>]
    Image: string

    [<JsonProperty("change")>]
    Change: int64

    [<JsonProperty("owner")>]
    Owner: string

    [<JsonProperty("parent_id")>]
    ParentId: int

    [<JsonProperty("rating")>]
    Rating: string

    [<JsonProperty("sample")>]
    Sample: bool

    [<JsonProperty("sample_height")>]
    SampleHeight: int

    [<JsonProperty("sample_width")>]
    SampleWidth: int

    [<JsonProperty("score")>]
    Score: int

    [<JsonProperty("tags")>]
    Tags: string

    [<JsonProperty("source")>]
    Source: string

    [<JsonProperty("status")>]
    Status: string

    [<JsonProperty("has_notes")>]
    HasNotes: bool

    [<JsonProperty("comment_count")>]
    CommentCount: int }
