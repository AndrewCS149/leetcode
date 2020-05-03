/*
1342. Number of Steps to Reduce a Number to Zero
Difficulty: easy

Given a non-negative integer num, return the number of steps to reduce it to zero. If the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.
*/

var numberOfSteps = function (num) {
  var steps = 0;

  while (num !== 0) {

    if (num % 2 === 0) {
      num /= 2;
    } else {
      num -= 1;
    }

    steps++;
  }

  return steps;
};