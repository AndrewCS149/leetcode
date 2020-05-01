/*
771. Jewels and Stones
difficulty: easy

You're given strings J representing the types of stones that are jewels, and S 
representing the stones you have.  Each character in S is a type of stone you 
have.  You want to know how many of the stones you have are also jewels.

The letters in J are guaranteed distinct, and all characters in J and S are
letters. Letters are case sensitive, so "a" is considered a different type of stone from "A".
*/

var numJewelIsInStones = function (J, S) {

  var jewels = 0;

  for (var i = 0; i < 50; i++) {
    if (J.includes(S[i])) {
      jewels++;
    }
  }
  return jewels;
}

console.log(numJewelIsInStones('aA', 'aAAbbbb'));