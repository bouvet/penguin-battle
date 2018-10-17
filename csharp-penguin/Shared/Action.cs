using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPenguin.Shared
{
    public class Action
    {
        readonly string ROTATE_RIGHT = "rotate-right";
        readonly string ROTATE_LEFT = "rotate-left";
        readonly string ADVANCE = "advance";
        readonly string RETREAT = "retreat";
        readonly string SHOOT = "shoot";
        readonly string PASS = "pass";
        readonly Dictionary<string, string> MOVE_UP = new Dictionary<string, string> { { "top", "advance" }, { "bottom", "rotate-left" }, { "right", "rotate-left" }, { "left", "rotate-right" } };
        readonly Dictionary<string, string> MOVE_DOWN = new Dictionary<string, string> { { "top", "rotate-left" }, { "bottom", "advance" }, { "right", "rotate-right" }, { "left", "rotate-left" } };
        readonly Dictionary<string, string> MOVE_RIGHT = new Dictionary<string, string> { { "top", "rotate-right" }, { "bottom", "rotate-left" }, { "right", "advance" }, { "left", "rotate-right" } };
        readonly Dictionary<string, string> MOVE_LEFT = new Dictionary<string, string> { { "top", "rotate-left" }, { "bottom", "rotate-right" }, { "right", "rotate-left" }, { "left", "advance" } };
        private readonly Match _match;

        public Action(Match match)
        {
            _match = match;
        }
        public string ChooseAction()
        {
            var response = PASS;
            response = MoveTowardsCenterOfMap();
            return response;
        }

        string MoveTowardsCenterOfMap()
        {
            var centerPointX = (int)_match.MapWidth / 2;
            var centerPointY = (int)_match.MapHeight / 2;
            return MoveTowardsPoint(centerPointX, centerPointY);
        }

        string MoveTowardsPoint(int pointX, int pointY)
        {
            var penguinPositionX = _match.You.X;
            var penguinPositionY = _match.You.Y;
            var plannedAction = PASS;

            if (penguinPositionX < pointX)
            {
                plannedAction = MOVE_RIGHT[_match.You.Direction];
            }
            else if (penguinPositionX > pointX)
            {
                plannedAction = MOVE_LEFT[_match.You.Direction];
            }
            else if (penguinPositionY < pointY)
            {
                plannedAction = MOVE_DOWN[_match.You.Direction];
            }
            else if (penguinPositionY > pointY)
            {
                plannedAction = MOVE_UP[_match.You.Direction];
            }
            if (plannedAction == ADVANCE && WallInFrontOfPenguin())
            {
                return SHOOT;
            }
            return plannedAction;
        }

        bool DoesCellContainWall(int x, int y)
        {
            return _match.Walls.Where(wall => wall.X == x && wall.Y == y).ToList().Count > 0;
        }

        bool WallInFrontOfPenguin()
        {
            switch (_match.You.Direction)
            {
                case "top":
                    return DoesCellContainWall(_match.You.X, --_match.You.Y);
                case "bottom":
                    return DoesCellContainWall(_match.You.X, ++_match.You.Y);
                case "left":
                    return DoesCellContainWall(--_match.You.X, _match.You.Y);
                case "right":
                    return DoesCellContainWall(++_match.You.X, _match.You.Y);
                default:
                    return true;
            }
        }
    }
}
