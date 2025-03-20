package org.tasks;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

public class MainJunitTest {
    @Test
    void equilateral() {
        assertEquals("Equilateral", Triangle.checkTriangleType(5, 5, 5));
    }

    @Test
    void isosceles() {
        assertEquals("Isosceles", Triangle.checkTriangleType(5, 5, 8));
    }

    @Test
    void scalene() {
        assertEquals("Scalene", Triangle.checkTriangleType(3, 4, 5));
    }

    @Test
    void notATriangle() {
        assertEquals("NotATriangle", Triangle.checkTriangleType(1, 1, 3));
    }

    @Test
    void valueOfAOutOfRange() {
        assertEquals("Value of a is not in the range of permitted values.", Triangle.checkTriangleType(0, 5, 5));
    }

    @Test
    void valueOfBOutOfRange() {
        assertEquals("Value of b is not in the range of permitted values.", Triangle.checkTriangleType(5, 0, 5));
    }

    @Test
    void valueOfCOutOfRange() {
        assertEquals("Value of c is not in the range of permitted values.", Triangle.checkTriangleType(5, 5, 0));
    }

    @Test
    void conditionNotATriangle() {
        assertEquals("NotATriangle", Triangle.checkTriangleType(5, 2, 10));
    }

    @Test
    void largeTriangle() {
        assertEquals("Scalene", Triangle.checkTriangleType(35, 50, 30));
    }

    public class Triangle {
        public static String checkTriangleType(int a, int b, int c) {
            if (a < 1 || a > 200) {
                return "Value of a is not in the range of permitted values.";
            }
            if (b < 1 || b > 200) {
                return "Value of b is not in the range of permitted values.";
            }
            if (c < 1 || c > 200) {
                return "Value of c is not in the range of permitted values.";
            }
            if (a >= b + c || b >= a + c || c >= a + b) {
                return "NotATriangle";
            }
            if (a == b && b == c) {
                return "Equilateral";
            } else if (a == b || b == c || a == c) {
                return "Isosceles";
            } else {
                return "Scalene";
            }
        }
    }
}
