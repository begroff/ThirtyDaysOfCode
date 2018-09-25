using System;
using System.Collections.Generic;
using System.IO;

namespace Sandbox.ThirtyDaysOfCode
{
    public class Difference {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements) {
            this.elements = elements;
            this.maximumDifference = 0;
        }

        public void ComputeDifference() {
            int minValue = elements[0];
            int maxValue = elements[0];

            for (int i = 0; i < elements.Length; i++) {
                if (elements[i] < minValue) {
                    minValue = elements[i];
                }

                if (elements[i] > maxValue) {
                    maxValue = elements[i];
                }
            }

            maximumDifference = maxValue - minValue;
        }
    }
}