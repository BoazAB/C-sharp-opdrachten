using System;

namespace getters_and_setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog husky = new Dog();
            Ball stressball = new Ball();
            husky.FetchBall(stressball);
            Ball voetball = husky.GiveBall();
        }
    }
    class Dog
    {
        private Ball tennisball;
        public void FetchBall(Ball ball)
        {
            this.tennisball = ball;
        }
        public Ball GiveBall()
        {
            return tennisball;
        }
    }
    class Ball
    {

    }
}
