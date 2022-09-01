using System.Collections.Generic;

namespace Range
{
    public interface ICurrentSensor
    {
        public List<ValueToAmpsContainer> ConvertToAmps(decimal[] input);
    }
}
