using System;
using System.Collections.Generic;

namespace prep.gemskata
{
    public class GemsSolver
    {
        public int Solve(int n, int k)
        {
            // For each possible permutation
            int width = 2 ^ n;
            int height = k;

            var canvas = new Canvas();
            canvas.SetDimensions(width, height);

            // From starting state, try every possible block in every possible slot,
            // Then continue with the results
            GetSuccessfulResultsForCanvas(canvas);

            // Inspect results (walk the tree)
        }

        private void GetSuccessfulResultsForCanvas(Canvas canvas)
        {
            int width = canvas.Width;
            int height = canvas.Height;
            var successfulFitResults = new List<Canvas>();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    foreach (var blockVariant in GemBlockVariants.All)
                    {
                        Canvas result = null;
                        if (canvas.TryFitBlockInCell(blockVariant, i, j, out result))
                        {
                            // Successfully fit
                            successfulFitResults.Add(result);
                        }
                    }
                }
            }
            canvas.SuccessfulResults = new List<Canvas>(successfulFitResults);
            foreach(var result in canvas.SuccessfulResults)
            {
                GetSuccessfulResultsForCanvas(result);
            }
        }
        private int CountCanvasResults(Canvas canvas,ref int accumulator)
        {
            accumulator = canvas.SuccessfulResults.Count;
            foreach(var result in canvas.SuccessfulResults)
            {
                accumulator += CountCanvasResults(result, 0);
            }
        }
    }
}
