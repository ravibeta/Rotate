// Learn more about F# at http://fsharp.net

// This program rotates an array of n integers by m

module Sample
open System

let RotateByK k = 
    let swap (a, b) = (b, a)
    let arr = [| 51; 78; 25; 34; 45 |]
    for j = 0 to abs(k) - 1 do
        for i = 0 to arr.Length - 2 do
            let old = arr.[i]
            let index = (arr.Length+1+i) % arr.Length
            let nu = arr.[index]
            arr.SetValue(nu, i)
            arr.SetValue(old,index)
            printfn "Array is now %A :" arr
    arr
let result = RotateByK 2
printfn "Array is now %A :" result