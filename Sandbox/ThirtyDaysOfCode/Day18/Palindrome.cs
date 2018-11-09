using System;
using System.Collections.Generic;

namespace Sandbox.ThirtyDaysOfCode.Day18
{
    public class Palindrome
    {
        private Stack<char> characterStack = new Stack<char>();
        private Queue<char> characterQueue = new Queue<char>();

        public bool CheckForPalindrome(string word)
        {
            bool isPalindrome = true;

            // Create the stack and queue
            foreach (char character in word)
            {
                pushCharacter(character);
                enqueueCharacter(character);
            }

            // Only need to loop through half the word
            // as we are grabbing the letter twice in our queue/stack
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (popCharacter() != dequeueCharacter())
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }

        public void pushCharacter(char ch)
        {
            characterStack.Push(ch);
        }

        public void enqueueCharacter(char ch)
        {
            characterQueue.Enqueue(ch);
        }

        public char popCharacter()
        {
            return characterStack.Pop();
        }

        public char dequeueCharacter()
        {
            return characterQueue.Dequeue();
        }
    }
}
