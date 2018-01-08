using System.Diagnostics.CodeAnalysis;

namespace Core2.Selkie.Common
{
    [ExcludeFromCodeCoverage]
    public sealed class Constants
    {
        public enum CircleOrigin
        {
            Start,
            Finish,
            Unknown
        }

        public enum CircleSide
        {
            Port,
            Starboard,
            Unknown
        }

        public enum LineDirection
        {
            Forward,
            Reverse,
            Unknown
        }

        public enum Origin
        {
            Start,
            Finish,
            Unknown
        }

        public enum Side
        {
            Port,
            Starboard,
            Unknown
        }

        public enum TurnDirection
        {
            Clockwise,
            Counterclockwise,
            Unknown
        }

        public const double EpsilonRadians = 1E-10;
        public const double EpsilonDegrees = 1E-10;
        public const double EpsilonPointXy = 1E-2;
        public const double EpsilonDistance = 1E-2;
        public const double Epsilon = 0.01;
    }
}