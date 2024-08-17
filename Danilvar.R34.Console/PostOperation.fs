module Danilvar.R34.Console.PostOperation

open System
open Danilvar.R34.Client

let print (post: Post) =
  Console.WriteLine($"ID: {post.Id}")
  Console.WriteLine($"Preview URL: {post.PreviewUrl}")
  Console.WriteLine($"File URL: {post.FileUrl}")
  Console.WriteLine($"Tags: {post.Tags}")
  Console.WriteLine($"Owner: {post.Owner}")

let printList posts = posts |> Seq.iter print
