using System;

namespace Global.Common.Extensions
{
    public static class FileExtensions
    {
        public static string ToPrettySize(this long value, int decimalPlaces = 0)
        {
            const long OneKb = 1024;
            const long OneMb = OneKb * 1024;
            const long OneGb = OneMb * 1024;
            const long OneTb = OneGb * 1024;

            var asTb = Math.Round((double) value / OneTb, decimalPlaces);
            var asGb = Math.Round((double) value / OneGb, decimalPlaces);
            var asMb = Math.Round((double) value / OneMb, decimalPlaces);
            var asKb = Math.Round((double) value / OneKb, decimalPlaces);
            var chosenValue = asTb > 1
                ? $"{asTb} TB"
                : asGb > 1
                    ? $"{asGb} GB"
                    : asMb > 1
                        ? $"{asMb} MB"
                        : asKb > 1
                            ? $"{asKb} KB"
                            : $"{Math.Round((double) value, decimalPlaces)} bytes";

            return chosenValue;
        }
    }
}