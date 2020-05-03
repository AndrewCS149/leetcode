/*
1281. Subtract the Product and Sum of Digits of an Integer
Difficulty: easy

Given an integer number n, return the difference between the 
product of its digits and the sum of its digits.
*/

// var subtractProductAndSum = function (n) {

//   var product = 1;
//   var sum = 0;
//   var remainder;

//   while (n > 0) {
//     remainder = n % 10;
//     product *= remainder;
//     // sum += remainder;
//     n /= 10;
//   }
//   return Math.floor(product);
//   // return Math.floor(product - sum);
// };

var subtractProductAndSum = function (n) {

  var arr = ('' + n).split('');
  var product = 1;
  var sum = 0;

  for (var i = 0; i < arr.length; i++) {
    sum += Number(arr[i]);
    product *= Number(arr[i]);
  }

  return product - sum;
};


console.log(subtractProductAndSum(114));