
namespace Day01
{
    public class Dial
    {
        public int Value { get; private set; } = 50;
        public int Password { get; private set; } = 0;
        public int PasswordMethodB { get; private set; } = 0;

        public void Rotate(int rotationValue)
        {
            if (rotationValue > 0)
            {
                for (int i = 0; i < rotationValue; i++)
                {
                    Value++;
                    if (Value > 99)
                        Value -= 100;
                    if (Value == 0)
                        PasswordMethodB++;
                }
            }

            if (rotationValue < 0)
            {
                for (int i = 0; i > rotationValue; i--)
                {
                    Value--;
                    if (Value == 0)
                        PasswordMethodB++;
                    if (Value < 0)
                        Value += 100;
                }
            }

            if (Value == 0)
                Password++;
        }
    }
}
