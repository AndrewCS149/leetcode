/*
1323. Maximum 69 Number
Difficulty: easy

Given a positive integer num consisting only of digits 6 and 9.

Return the maximum number you can get by changing at most one digit (6 becomes 9, and 9 becomes 6).

Example 1:

Input: num = 9669
Output: 9969
Explanation: 
Changing the first digit results in 6669.
Changing the second digit results in 9969.
Changing the third digit results in 9699.
Changing the fourth digit results in 9666. 
The maximum number is 9969.
*/

var maximum69Number = function (num) {

  var array = [];
  var numStr = num.toString();
  var max = num;

  for (var i = 0; i < numStr.length; i++) {
    array.push(+numStr.charAt(i));
  }

  for (var i = 0; i < array.length; i++) {
    var temp = array;
    temp = Number(temp.join(''));

    if (array[i] === 6) {
      array[i] = 9;
      if (Number(array.join('')) > max) {
        max = Number(array.join(''));
      }
      array[i] = 6;
    }
    console.log(max);
  }
};
maximum69Number(9669);