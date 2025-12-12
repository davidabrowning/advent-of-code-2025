using System.Numerics;

namespace Day02
{
    public static class FileReader
    {
        public static List<IdRange> GetIdRanges(string filename)
        {
            List<IdRange> idRanges = new();
            foreach (string idRangeString in File.ReadAllText(filename).Split(","))
            {
                string[] idRangeStringParts = idRangeString.Split("-");
                BigInteger firstId = Convert.ToInt64(idRangeStringParts[0]);
                BigInteger lastId = Convert.ToInt64(idRangeStringParts[1]);
                IdRange idRange = new(firstId, lastId);
                idRanges.Add(idRange);
            }
            return idRanges;
        }
    }
}
