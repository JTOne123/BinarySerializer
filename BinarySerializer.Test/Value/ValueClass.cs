﻿namespace BinarySerialization.Test.Value
{
    public class ValueClass
    {
        [FieldOrder(0)]
        public int Length { get; set; }

        [FieldOrder(1)]
        [FieldLength("Length")]
        [FieldCrc16("Crc")]
        public ValueInternalClass Internal { get; set; }

        [FieldOrder(2)]
        public int Crc { get; set; }
    }
}
