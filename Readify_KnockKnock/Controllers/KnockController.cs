using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Readify_KnockKnock.Controllers
{
    public class KnockController : ApiController
    {
        [HttpGet]
        [HttpPost]
        public long Fibonacci(long n)
        {
            return GetFibonacciRecursive(n);
        }

        [HttpGet]
        [HttpPost]
        public string ReverseWords(string sentence)
        {
            return string.Join(" ", sentence.Split(' ')
                .Select(x => new String(x.Reverse().ToArray())));
        }

        [HttpGet]
        [HttpPost]
        public string Token()
        {
            return "81054b7b-9127-4ed1-bb28-2d880c1117a7";
        }

        [HttpGet]
        [HttpPost]
        public string TriangleType(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return "Equilateral";
            }
            else if ((a == b) || (b == c) || (a == c))
            {
                return "Isosceles";
            }
            else if ((a >= b + c) || (b >= a + c) || (c >= a + b) || (a <= 0) || (b <= 0) || (c <= 0))
            {
                return "Error";
            }
            else
            {
                return "Scalene";
            }
        }

        private long GetFibonacciRecursive(long n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
                return GetFibonacciRecursive(n - 1) + GetFibonacciRecursive(n - 2);
        }
    }
}
