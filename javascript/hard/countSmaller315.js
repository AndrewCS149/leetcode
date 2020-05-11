/*
315. Count of Smaller Numbers After Self
Difficulty: hard

You are given an integer array nums and you have to return a new 
counts array. The counts array has the property where counts[i] 
is the number of smaller elements to the right of nums[i].
*/

var countSmaller = function (nums) {

  var numbers = [];
  var numsLength = nums.length;
  var i;
  for (i = 0; i < numsLength; i++) {
    var smallerNums = 0;

    var k;
    for (k = i; k < numsLength - 1; k++) {
      if (nums[i] > nums[k + 1]) {
        smallerNums++;
      }
    }
    numbers.push(smallerNums);
  }

  return numbers;
};


var testArr = [5, 2, 6, 1];
console.log(countSmaller(testArr));


// UNFINISHED /////////////////////////////////////////////////////
// leetcode did not accept this submission. The built took too long. 