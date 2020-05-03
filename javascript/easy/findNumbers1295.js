/*
1295. Find Numbers with Even Number of Digits
Difficulty: easy

Given an array nums of integers, return how many of them contain an even number of digits.
*/

var findNumbers = function (nums) {

  var evens = 0;

  for (var i = 0; i < nums.length; i++) {
    if (String(nums[i]).length % 2 === 0) {
      evens++;
    }
  }

  return evens;
};


var numArray = [555, 901, 482, 1771];
console.log(findNumbers(numArray));