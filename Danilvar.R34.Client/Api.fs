module Danilvar.R34.Client.Api
open System.Net.Http
open Newtonsoft.Json

let baseUrl = "https://api.rule34.xxx/index.php?page=dapi&json=1&s="

let endpoint (url: string) = $"{baseUrl}{url}"

let postEndpoint (query: string) = endpoint $"post&q=index{query}"
 
let parseList<'T> response = JsonConvert.DeserializeObject<'T list>(response)   
let parse<'T> response = JsonConvert.DeserializeObject<'T>(response)   

let httpGet (url: string) =
  async {
    use client = new HttpClient()
    let! response = client.GetStringAsync(url) |> Async.AwaitTask
    return response
  }

let listRequest<'T> (url: string) =
   async {
    let! response = httpGet(url)
    let result = parseList<'T>(response)
    return result
   }
   
let getRequest<'T> (url: string) =
  async {
    let! response = httpGet(url)
    let result = parseList<'T>(response)
    return result[0]
  }
  
