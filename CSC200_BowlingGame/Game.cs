using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC200_BowlingGame
{
    public class Game
    { 
        private int[] _rolls = new int[21];
        private int _turn = 0;


        public void Roll(int pins)
        {
            
            _rolls[_turn++] = pins;
            
        }

        public int Score()
        {
            int score = 0;
            int roll = 0;
            
            for (int frame = 0; frame < 10; frame++)
            {
                if(_rolls[roll] == 10) // strike
                {
                    score += 10 + _rolls[roll + 1] + _rolls[roll + 2];
                    roll += 1;
                }

                else if (IsSpareFrame(roll)) //spare
                {
                    score += 10 + _rolls[roll + 2];
                    roll += 2;
                }
                else
                {
                    score += _rolls[roll] + _rolls[roll + 1];
                    roll += 2;
                }
               
            }

            return score;
        }

        private bool IsSpareFrame(int roll)
        {
            return _rolls[roll] + _rolls[roll + 1] == 10;
        }

            //for (int roll = 0; roll < _rolls.Length; roll++)
            //{
            //    score += _rolls[roll];
            //}

           // return score;
        
    }
}
