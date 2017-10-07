
open System

exception IsNeg of int[]

let SumNum (numbers :string) =
  
    let  x=numbers.Substring  ((numbers.IndexOf "\n") + 1 ) 
    if numbers.Contains "[" then 
      let Delim =  [ numbers .[3 .. numbers.IndexOf("]")-1] ]
      x.Split ((Delim |> Array.ofList), StringSplitOptions.RemoveEmptyEntries) |> Array.map Int32.Parse |> Array.sum 
    else 
    x.Split [|numbers.[2]|] 

   |> Array.map Int32.Parse
   |> Array.filter (fun i -> i <1000)
   |> Array.sum 
  
let SumNeg numbers  = 
   match numbers |> Array.filter (fun n -> n <0) with
     | negNums when negNums.Length> 0 -> raise (IsNeg negNums) 
     | _ -> numbers
  
   
let Add (numbers : string) =
   
   match numbers with 
    | "" -> 0
   // | _ when numbers.StartsWith "//[" -> 
     //  let Delim = numbers .[3 .. numbers.IndexOf("]")]
       //([|Delim|], numbers.[numbers.IndexOf("\n") .. (numbers.Length -1)]) 
    | _ when numbers.StartsWith "//" -> SumNum numbers

            

Add "//[,,,]\n4,,,1,,,-1"




