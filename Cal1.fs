
open System

exception IsNeg of int[]

let SumNum (numbers :string) =
     let  x=numbers.Substring  ((numbers.IndexOf "\n") + 1 ) 
     x.Split [|numbers.[2]|]  
 
   |> Array.map Int32.Parse 
   |> Array.sum

  
let SumNeg numbers  = 
   match numbers |> Array.filter (fun n -> n <0) with
     | negNums when negNums.Length> 0 -> raise (IsNeg negNums) 
     | _ -> numbers
 


let Add (numbers : string) =
   
   match numbers with 
    | "" -> 0

    | _ when numbers.StartsWith "//" -> SumNum numbers

            

Add "//;\n2;-3;5"



