/*
1365. How Many Numbers Are Smaller Than the Current Number
Difficulty: easy

Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].

Return the answer in an array.
*/

var smallerNumbersThanCurrent = function (nums) {

  var numbers = [];
  for (var i = 0; i < nums.length; i++) {
    var smallerNums = 0;

    for (var k = 0; k < nums.length; k++) {
      if (nums[i] < nums[k]) {
        smallerNums++;
      }
    }
    numbers.push(smallerNums);
  }

  return numbers;
};