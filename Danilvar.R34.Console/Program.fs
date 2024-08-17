open System
open Danilvar.R34.Client
open Danilvar.R34.Console
open Spectre.Console

let logo = @"
 _______   __     __                           _______           ______   __    __ 
|       \ |  \   |  \                         |       \         /      \ |  \  |  \
| $$$$$$$\| $$   | $$ ______    ______        | $$$$$$$\       |  $$$$$$\| $$  | $$
| $$  | $$| $$   | $$|      \  /      \       | $$__| $$ ______ \$$__| $$| $$__| $$
| $$  | $$ \$$\ /  $$ \$$$$$$\|  $$$$$$\      | $$    $$|      \ |     $$| $$    $$
| $$  | $$  \$$\  $$ /      $$| $$   \$$      | $$$$$$$\ \$$$$$$__\$$$$$\ \$$$$$$$$
| $$__/ $$   \$$ $$ |  $$$$$$$| $$            | $$  | $$       |  \__| $$      | $$
| $$    $$    \$$$   \$$    $$| $$            | $$  | $$        \$$    $$      | $$
 \$$$$$$$      \$     \$$$$$$$ \$$             \$$   \$$         \$$$$$$        \$$
 "

 
AnsiConsole.WriteLine(logo)

let rec menu () =
    AnsiConsole.MarkupLine("[bold underline green]Выберите действие:[/]")
    AnsiConsole.MarkupLine("[yellow]  1. Показать последние посты[/]")
    AnsiConsole.MarkupLine("[yellow]  2. Найти посты по тегам[/]")
    AnsiConsole.MarkupLine("[yellow]  3. Показать конкретный пост по ID[/]")
    AnsiConsole.MarkupLine("[yellow]  4. Выход[/]")
    
    match Console.ReadLine() with
    | "1" -> showRecentPosts ()
    (*| "2" -> searchPostsByTags ()
    | "3" -> showPostById ()*)
    | "4" -> AnsiConsole.MarkupLine("[bold red]Выход...[/]"); Environment.Exit(0)
    | _ -> AnsiConsole.MarkupLine("[bold red]Некорректный выбор, попробуйте снова.[/]"); menu ()

and showRecentPosts () =
    AnsiConsole.Markup("[bold cyan]Введите количество постов для отображения: [/]")
    let limit = int (Console.ReadLine())
    AnsiConsole.Markup("[bold cyan]Введите номер страницы (нажмите Enter для первой страницы): [/]")
    let pageNumber = Console.ReadLine() |> function | "" -> None | s -> Some (int s)
    
    AnsiConsole.MarkupLine("Получение постов...")
    let posts = Posts.list limit pageNumber None |> Async.RunSynchronously
    PostOperation.printList posts
    AnsiConsole.MarkupLine("----- Конец списка -----")
    menu ()




menu()


