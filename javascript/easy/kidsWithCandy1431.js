/*
1431. Kids with the greatest number of candies
Difficulty: easy

Given the array candies and the integer extraCandies, where candies[i] represents the number of candies that the ith kid has.

For each kid check if there is a way to distribute extraCandies among the kids such that he or she can have the greatest number of candies among them. Notice that multiple kids can have the greatest number of candies.
*/

var kidsWithCandies = function (candies, extraCandies) {

  // find kid with most candies
  var mostCandies = candies[0];
  for (var i = 1; i < candies.length; i++) {
    if (candies[i] > mostCandies) {
      mostCandies = candies[i];
    }
  }

  // compare every kid to the kid with the most candies
  var candyArr = [];
  for (var i = 0; i < candies.length; i++) {
    if (candies[i] + extraCandies >= mostCandies) {
      candyArr.push(true);
    } else {
      candyArr.push(false);
    }
  }

  return candyArr;
};