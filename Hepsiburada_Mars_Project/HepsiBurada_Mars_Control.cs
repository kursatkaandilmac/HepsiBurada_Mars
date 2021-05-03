using System;
using System.Collections.Generic;

namespace HepsiBurada_Mars_Control
{
    public enum Directions
    {
        N = 1,
        S = 2,
        E = 3,
        W = 4
    }

    public interface IHepsiBurada_Mars_Control
    {
        void StartMoving(List<int> maxPoints, string moves);
    }

    public class HepsiBurada_Mars_Control : IHepsiBurada_Mars_Control
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Direction { get; set; }

        public HepsiBurada_Mars_Control()
        {
            X = Y = 0;
            Direction = Directions.N;
        }

        private void Rotate90Left()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.W;
                    break;
                case Directions.S:
                    this.Direction = Directions.E;
                    break;
                case Directions.E:
                    this.Direction = Directions.N;
                    break;
                case Directions.W:
                    this.Direction = Directions.S;
                    break;
                default:
                    break;
            }
        }

        private void Rotate90Right()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.E;
                    break;
                case Directions.S:
                    this.Direction = Directions.W;
                    break;
                case Directions.E:
                    this.Direction = Directions.S;
                    break;
                case Directions.W:
                    this.Direction = Directions.N;
                    break;
                default:
                    break;
            }
        }

        private void MoveInSameDirection()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Y += 1;
                    break;
                case Directions.S:
                    this.Y -= 1;
                    break;
                case Directions.E:
                    this.X += 1;
                    break;
                case Directions.W:
                    this.X -= 1;
                    break;
                default:
                    break;
            }
        }


        public void StartMoving(List<int> maxPoints, string moves)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        this.MoveInSameDirection();
                        break;
                    case 'L':
                        this.Rotate90Left();
                        break;
                    case 'R':
                        this.Rotate90Right();
                        break;
                    default:
                        Console.WriteLine($"Hatalı Karakter {move}");
                        break;
                }

                if (this.X < 0 || this.X > maxPoints[0] || this.Y < 0 || this.Y > maxPoints[1])
                {
                    throw new Exception($"Boyundan büyük işlere kalkıyorsun :) ==> Boyundan Büyük Konumlandırma Yapmayınız :  ({maxPoints[0]} , {maxPoints[1]})");
                }
            }
        }
    }
}
