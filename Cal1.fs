open System

let Add (numbers : String) : int =
 
 let sumArr = Array.fold (fun acc elem -> acc + (int elem))  0
 
 match numbers with
   | "" -> 0  
   | _ when numbers.StartsWith "//" ->
       let x= (numbers.IndexOf "//") + 1
       let arr1 = numbers.Substring  ((numbers.IndexOf "\n") + 1 )
       arr1.Split [| numbers.[3] |] |> sumArr
   | _ ->
      numbers.Split [|',' ; '\n'|] |> sumArr
      


Add "//@\n3@3"