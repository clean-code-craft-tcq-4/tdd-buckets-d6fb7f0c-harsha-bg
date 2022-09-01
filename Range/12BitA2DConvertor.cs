using System;
using System.Collections.Generic;

namespace Range
{
    public class _12BitA2DConvertor : ICurrentSensor
    {
        public List<ValueToAmpsContainer> ConvertToAmps(decimal[] input)
        {
            List<ValueToAmpsContainer> convertedValues = new List<ValueToAmpsContainer>();
            foreach (var bitNum in input)
            {
                ValueToAmpsContainer values = new ValueToAmpsContainer();
                decimal toAmps = 10 * bitNum / 4094;
                if (toAmps > 10)
                    values.ErrorValue = 1;
                else
                    values.ValueToAmps = Math.Round(toAmps);
                convertedValues.Add(values);
            }

            return convertedValues;
        }
    }

    public class ValueToAmpsContainer
    {
        public decimal ValueToAmps;
        public int ErrorValue;
    }
}
