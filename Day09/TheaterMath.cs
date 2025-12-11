using System.Numerics;

namespace Day09
{
    public static class TheaterMath
    {
        public static BigInteger CalculateArea(Tile tileA, Tile tileB)
        {
            return (BigInteger)(Math.Abs(tileA.X - tileB.X) + 1) * (BigInteger)(Math.Abs(tileA.Y - tileB.Y) + 1);
        }

        public static bool ContainsAdjacentDiagonals(Tile rectangleVertex1, Tile rectangleVertext2, Tile targetTile)
        {
            if (!Contains(rectangleVertex1, rectangleVertext2, new Tile(targetTile.X - 1, targetTile.Y + 1)))
                return false;
            if (!Contains(rectangleVertex1, rectangleVertext2, new Tile(targetTile.X + 1, targetTile.Y + 1)))
                return false;
            if (!Contains(rectangleVertex1, rectangleVertext2, new Tile(targetTile.X + 1, targetTile.Y - 1)))
                return false;
            if (!Contains(rectangleVertex1, rectangleVertext2, new Tile(targetTile.X - 1, targetTile.Y - 1)))
                return false;
            return true;
        }

        public static bool Contains(Tile rectangleVertex1, Tile rectangleVertext1, Tile targetTile)
        {
            if (targetTile.X > Math.Max(rectangleVertex1.X, rectangleVertext1.X))
                return false;
            if (targetTile.X < Math.Min(rectangleVertex1.X, rectangleVertext1.X))
                return false;
            if (targetTile.Y > Math.Max(rectangleVertex1.Y, rectangleVertext1.Y))
                return false;
            if (targetTile.Y < Math.Min(rectangleVertex1.Y, rectangleVertext1.Y))
                return false;
            return true;
        }

        public static BigInteger MaxArea(IEnumerable<Tile> redTiles)
        {
            BigInteger maxArea = 0;
            foreach (Tile tileA in redTiles)
            {
                foreach (Tile tileB in redTiles)
                {
                    BigInteger area = CalculateArea(tileA, tileB);
                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
            }
            return maxArea;
        }

        public static BigInteger MaxAreaRedGreenOnly(IEnumerable<Tile> redTiles)
        {
            BigInteger maxArea = 0;
            foreach (Tile tileA in redTiles)
            {
                foreach (Tile tileB in redTiles)
                {
                    BigInteger area = CalculateArea(tileA, tileB);

                    // If area isn't bigger than max area so far, don't even bother running checks
                    if (area <= maxArea)
                        continue;

                    // Check: If this rectangle fully contains another red tile, then it must lie both inside (good)
                    // and at least partially outside (bad) the polygon's border
                    if (FullyContainsAnotherRedTile(tileA, tileB, redTiles))
                        continue;

                    // Check: If this rectangle lies on both sides of the perimeter line between two other red tiles,
                    // then it must lie at least partially outside (bad) the polygon's border
                    if (ContainsPointsOnBothSidesOfPerimeter(tileA, tileB, redTiles))
                        continue;

                    // Checks passed, so update max area
                    maxArea = area;
                }
            }
            return maxArea;
        }

        private static bool ContainsPointsOnBothSidesOfPerimeter(Tile tileA, Tile tileB, IEnumerable<Tile> redTiles)
        {
            List<Tile> redTilesList = redTiles.ToList();
            redTilesList.Add(redTiles.ElementAt(0));

            for (int i = 0; i < redTilesList.Count - 1; i++)
            {
                Tile startTile = redTilesList[i];
                Tile endTile = redTilesList[i + 1];

                // If the tiles are in the same column
                if (startTile.X == endTile.X)
                {
                    int x = startTile.X;
                    int yStart = Math.Min(startTile.Y, endTile.Y);
                    int yEnd = Math.Max(startTile.Y, endTile.Y);
                    for (int y = yStart + 1; y < yEnd; y++)
                    {
                        Tile tileOnLeftOfPerimeter = new Tile(x - 1, y);
                        Tile tileOnRightOfPerimeter = new Tile(x + 1, y);
                        if (Contains(tileA, tileB, tileOnLeftOfPerimeter) && Contains(tileA, tileB, tileOnRightOfPerimeter))
                        {
                            return true;
                        }
                    }
                }

                // If the tiles are in the same row
                if (startTile.Y == endTile.Y)
                {
                    int y = startTile.Y;
                    int xStart = Math.Min(startTile.X, endTile.X);
                    int xEnd = Math.Max(startTile.X, endTile.X);
                    for (int x = xStart + 1; x < xEnd; x++)
                    {
                        Tile tileAbovePerimeter = new Tile(x, y + 1);
                        Tile tileBelowPerimeter = new Tile(x, y - 1);
                        if (Contains(tileA, tileB, tileAbovePerimeter) && Contains(tileA, tileB, tileBelowPerimeter))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private static bool FullyContainsAnotherRedTile(Tile vertexA, Tile vertextB, IEnumerable<Tile> redTiles)
        {
            foreach (Tile tileC in redTiles)
            {
                if (ContainsAdjacentDiagonals(vertexA, vertextB, tileC))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
