/*
938. Range Sum of BST
Difficulty: easy 

Given the root node of a binary search tree, return the sum of values of all nodes with value between L and R (inclusive).

The binary search tree is guaranteed to have unique values.

Example: 

Input: root = [10,5,15,3,7,null,18], L = 7, R = 15
Output: 32
*/

// TODO: FIX BINARY SEARCH TREE

var rangeSumBST = function (root, L, R) {

  var sum = 0;
  for (var i = 0; i < root.length; i++) {

    if (root[i] >= L && root[i] <= R) {
      sum += root[i];
    }
  }

  return sum;
};

var testArr = [10, 5, 15, 3, 7, 13, 18, 1, null, 6];
var boundaryL = 6;
var boundaryR = 10;

console.log(rangeSumBST(testArr, boundaryL, boundaryR));