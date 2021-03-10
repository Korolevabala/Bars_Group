// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let square x = x * x
let getSquares items =
   items |> List.map square
   
let lst =[1;2;3;4;5]
printf "квадрат числа %A равен %A" lst (getSquares lst)
//let rec quicksort =
   // function
   // | [] -> []
    //| x::xs ->
       // let lesser = List.filter((>) x) xs
       // let greater = List.filter((<=) x) xs
       // (quicksort lesser) @ [x] @ (quicksort greater)