using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GME1011AnimationTest
{
    internal class Hero
    {
        private List<Texture2D> _runSprites;
        private int _health;
        private string _name;
        private int _currentSpriteIndex;
        private int _totalFrameCount;

        public Hero(List<Texture2D> runSpritesIn, int health, string name)
        {
            _runSprites = runSpritesIn;
            _health = health;
            _name = name;   
            _currentSpriteIndex = 0;
        }

        public int GetHealth() {  return _health; }
        public string GetName() { return _name; }

        public void TakeDamage(int damage) { _health -= damage; }

        public void Draw(SpriteBatch spriteBatch)
        {
            _totalFrameCount++;

            spriteBatch.Begin();
            spriteBatch.Draw(_runSprites[_currentSpriteIndex], new Vector2(10, 10), Color.White);

            if(_totalFrameCount %10 == 0)
                _currentSpriteIndex++;

            if(_currentSpriteIndex >= _runSprites.Count)
                _currentSpriteIndex = 0;


            spriteBatch.End();
        }
    }
}
