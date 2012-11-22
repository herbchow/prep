using System;
using System.Collections.Generic;

namespace prep.gemskata
{
    public class Canvas
    {
        private CanvasCell[,] _canvas;
        public List<Canvas> SuccessfulResults { get; set; } 
        private int _width;

        public int Width
        {
            get { return _width; }
            private set
            {
                if (value > (2 ^ 1024))
                    throw new ArgumentException();

                _width = value;
            }
        }

        private int _height;

        public int Height
        {
            get { return _height; }
            private set
            {
                if (value > 5 || value < 1)
                    throw new ArgumentException();
                _height = value;
            }
        }

        public Canvas()
        {
        }

        public void SetDimensions(int width,int height)
        {
            Width = width;
            Height = height;
            BuildBlankCanvas();
        }

        private void BuildBlankCanvas()
        {
            _canvas = new CanvasCell[Width,Height];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    _canvas[i, j] = CanvasCell.FreeCell;
                }
            }
        }

        public IEnumerable<Canvas> AddBlockInAllPossibleLocationsReturningResults(GemBlocks block)
        {
            var permutationsList = new List<Canvas>();
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    Canvas resultCanvas;
                    if(TryFitBlockInCell(block,i,j,out resultCanvas))
                    {
                        permutationsList.Add(resultCanvas);
                    }
                }
            }
            return permutationsList;
        }

        public bool TryFitBlockInCell(GemBlocks block, int x, int y,out Canvas resultCanvas)
        {
            List<int> xCoordsToFill = new List<int>();
            List<int> yCoordsToFill = new List<int>();
            for (int i = 1; i <= block.width; i++)
            {
                int currBlockX = x + block.width - 1;
                xCoordsToFill.Add(currBlockX);
                if (_canvas[currBlockX, y] == CanvasCell.OccupiedCell)
                {
                    resultCanvas = null;
                    return false;
                }
            }
            for (int i = 1; i < block.height; i++)
            {
                int currBlockY = y + _height - 1;
                yCoordsToFill.Add(currBlockY);
                if (_canvas[x, currBlockY] == CanvasCell.OccupiedCell)
                {
                    resultCanvas = null;
                    return false;
                }
            }
            resultCanvas = Duplicate();
            // Fill x & y
            foreach(var index in xCoordsToFill)
            {
                resultCanvas.FillCell(index,y);
            }
            foreach(var index in yCoordsToFill)
            {
                if(index != y)
                    resultCanvas.FillCell(x,index);
            }

            return true;
        }

        public void FillCell(int x,int y)
        {
            if(_canvas[x,y] == CanvasCell.OccupiedCell)
                throw new InvalidOperationException("Cell is already filled");

            _canvas[x, y] = CanvasCell.OccupiedCell;
        }

        public Canvas Duplicate()
        {
            var dupe = new Canvas();
            dupe.SetDimensions(Width,Height);
            for(int i = 0; i < Width;i++)
            {
                for(int j = 0;j < Height;j++)
                {
                    dupe._canvas[i,j] = _canvas[i,j];
                }
            }
            return dupe;
        }
    }
}
