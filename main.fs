module Assignment

// Problem 1
let rec prod (lst:int list) =
    // write your solution here
   if List.isEmpty lst
    then 1
    else List.head lst * prod (List.tail lst)

// Problem 2
let rec map f (lst:int list) =
    // write your solution here
 if List.isEmpty lst then []
 else (f (List.head lst))::(map f (List.tail lst ))



    //match lst with
    //[] -> []
    //|h::t->(f h)::(map f t)

// Problem 3

let rec odd (lst:int list) = 
    // write your solution here
  if List.isEmpty lst then []
  else 
    let h = List.head lst 
    let t = List.tail lst
    if h % 2 = 1 then h::(odd t) 
    else odd t 


// Problem 4
let rec filter f (lst:int list) =
    // write your solution here
  if List.isEmpty lst then []
  else 
    let h = List.head lst 
    let t = List.tail lst
    if f h then h::(filter f t) 
    else filter f t
