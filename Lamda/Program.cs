using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ArrayList list = new ArrayList() { -1, 10, 3, 99, 500, 0, 20 };

            // UniversalSort.Sort(ref list, IntComparator);
            UniversalSort.Sort(ref list, (_currentElement, _nextElement) => {
                return  (int)_nextElement- (int)_currentElement;
            });

            foreach (var item in list)
            {
                Console.WriteLine(item);
            } */

            ArrayList list = new ArrayList() {
                new Person(){ firstName = "John", surname = "Connor", age = 30 },
                new Person(){ firstName = "Vasia", surname = "Pupkin", age = 35 },
                new Person(){ firstName = "John", surname = "Doe", age = 25 },
                new Person(){ firstName = "Masha", surname = "Pupkina", age = 20 },
                new Person(){ firstName = "Ivan", surname = "Ivanovich", age = 40 },
                new Person(){ firstName = "John", surname = "Avtor", age = 30 }
            };

            // UniversalSort.Sort(ref list, IntComparator);
            UniversalSort.Sort(ref list, (_currentElement, _nextElement) => {return ((Person)_currentElement).firstName.CompareTo(((Person)_nextElement).firstName); },
                (_currentElement, _nextElement) => {return ((Person)_currentElement).surname.CompareTo(((Person)_nextElement).surname);
            });

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        /* static int IntComparator(Object _currentElement, Object _nextElement) {
            return (int)_currentElement - (int)_nextElement;
        }

        static int IntReverseComparator(Object _currentElement, Object _nextElement)
        {
            return (int)_nextElement - (int)_currentElement;
        } */
    }
}
