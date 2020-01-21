# BalancingScalesApp
Solution to the following exercise found online:

You have a set of scales which are unbalanced and the aim is to use a maximum of two of the remaining weights to see if you can balance the scales. If you do need to use 2 weights they can be placed on the same scale.

Write a function that can accept 3 arguments. The first argument will be an integer greater than 0 that represents the current weight of the left scale, the second argument will be an integer greater than 0 that represents the weight of the right scale and the last argument will be an array of positive integers that represent the weights you currently have remaining to use.

For example (5, 9, [3,5,8,12]). 5 represents the left scale’s current weight. 9 represents the right scale’s current weight and the array represents the weights you have at your disposal.

If you can balance the scales then the function should return an array of the number(s) required to make the scales balance. Otherwise it can return nil/null.

Examples
input (6, 8, [3, 4, 5, 8])
output [3, 5]

input (1,2, [4, 7, 9, 1])
output [1]

input (5, 9, [ 1, 3, 6, 7])
output [1, 3] #=> can both be placed on the left scale to make it weigh 9

input (3, 6, [2, 6, 7, 19])
output nil

_____________________

Learned much much more about arrays than I previously knew. Had some help from a friend to work out some of the maths. Take-away is to just keep doing these challenges until more comfortable. 
