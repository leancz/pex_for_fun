module Program

// Can you write code to solve the puzzle? Ask Pex to see how close you are.
// 0 : 0
// 1 : 1
// 2 : 3
// 4 : 11
// 7 : 53
// 8 : 87
// 9 : 142
// modified Fibonacci x + y + 2
let rec Puzzle (x : int) : int = 
  if x = 0 then 0
  elif x = 1 then 1
  else (Puzzle (x - 1)) + (Puzzle (x - 2)) + 2
