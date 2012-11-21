using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prep.gemskata
{
    public class GemSolverCanvas
    {
        private CanvasCell[,] _canvas;

        private int _width = int.MinValue;
        private int _height = int.MinValue;

        public GemSolverCanvas(int width,int height)
        {
            _canvas = new CanvasCell[width, height];
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    _canvas[i,j] = CanvasCell.FreeCell;
                }
            }
        }

        public IEnumerable<GemSolverCanvas> AddBlockInAllPossibleLocationsReturningResults(GemBlocks block)
        {
            for(int i = 0; i < _width; i++)
            {
                for(int j = 0; j < _height; j++)
                {
                    
                }
            }
        }

        public bool DoesBlockFitInCell(GemBlocks block,int x,int y)
        {
            for(int i = 1; i <= block.width; i++)
            {
                int currBlockX = x + _width - 1
                if(_canvas[x,y] == CanvasCell.OccupiedCell)
                {
                    
                }
            }
            _canvas[x,y] 
        }
    }
}
