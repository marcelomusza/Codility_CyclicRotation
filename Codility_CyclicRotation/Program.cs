// See https://aka.ms/new-console-template for more information
using Codility_CyclicRotation;

Console.WriteLine("Codility Exercise - CyclicRotation");

var A = new int[] { 1, 2, 3, 4 };
var K = 2;

var rotatedArray = Solution.RotateArray(A, K);

var formattedArray = string.Join(", ", rotatedArray.Select(item => item.ToString()));

Console.WriteLine($"[ {formattedArray} ]");


