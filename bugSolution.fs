let x = 10
let y = 20

let add x y =  x + y

let inline mutableAdd x y = 
    let mutable xCopy = x
    let mutable yCopy = y
    xCopy <- xCopy + yCopy
    yCopy <- yCopy + xCopy
    xCopy + yCopy

printf "%A" (add x y)
printf "%A" (mutableAdd x y)