using System.Numerics;

namespace Day02
{
    public class IdRange
    {
        public BigInteger FirstId { get; set; }
        public BigInteger LastId { get; set; }

        public IdRange(BigInteger firstId, BigInteger lastId)
        {
            FirstId = firstId;
            LastId = lastId;
        }

        public override bool Equals(object? obj)
        {
            return obj is IdRange otherIdRange &&
                   FirstId == otherIdRange.FirstId &&
                   LastId == otherIdRange.LastId;
        }
    }
}
