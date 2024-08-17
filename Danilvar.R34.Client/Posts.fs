module Danilvar.R34.Client.Posts

open System

let list (limit: int) (pageNumber: Option<int>) (tags: Option<string>) =
  async {
    let pid = pageNumber |> Option.map string |> Option.defaultValue ""
    let tagsRes = tags |> Option.defaultValue ""

    let url = Api.postEndpoint $"&limit={limit}&pid={pid}&tags={tagsRes}"
    let posts = Api.listRequest<Post> url |> Async.RunSynchronously
    return posts
  }

let get (id: int) =
  async {
    let url = Api.postEndpoint $"&id={id}"
    let post = Api.getRequest<Post> url |> Async.RunSynchronously
    return post
  }
