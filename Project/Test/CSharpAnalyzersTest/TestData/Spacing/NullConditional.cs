﻿using System.Collections.Generic;
using System.Linq;

namespace CSharpAnalyzersTest.TestData.Spacing
{
    internal class NullConditional
    {
        private void Method1()
        {
            List<string> list = new List<string>();
            var method1 = list?.FirstOrDefault();
            method1 = list ?.FirstOrDefault();
            method1 = list?. FirstOrDefault();
            method1 = list ?. FirstOrDefault();
            method1 = list?.FirstOrDefault()?.FirstOrDefault()?.FirstOrDefault();
            method1 = list ?.FirstOrDefault()?.FirstOrDefault()?.FirstOrDefault();
            method1 = list?. FirstOrDefault()?.FirstOrDefault()?.FirstOrDefault();
            method1 = list ?. FirstOrDefault()?.FirstOrDefault()?.FirstOrDefault();
            method1 = list?.FirstOrDefault() ?.FirstOrDefault()?.FirstOrDefault();
            method1 = list?.FirstOrDefault()?. FirstOrDefault()?.FirstOrDefault();
            method1 = list?.FirstOrDefault() ?. FirstOrDefault()?.FirstOrDefault();
            method1 = list?.FirstOrDefault()?.FirstOrDefault() ?.FirstOrDefault();
            method1 = list?.FirstOrDefault()?.FirstOrDefault()?. FirstOrDefault();
            method1 = list?.FirstOrDefault()?.FirstOrDefault() ?. FirstOrDefault();
        }
    }

    public class NullConditionalNextTest
    {
        // test for this issue https://github.com/Visual-Stylecop/Visual-StyleCop/issues/10
        public void TestId10Issue()
        {
            var posts = new List<string>() { "abc", "123" };
            posts.First()?.Replace('a', 'z'); // allowed
            posts.First()?. Replace('a', 'z'); // not allowed
            posts.First() ?.Replace('a', 'z'); // not allowed
            posts.First() ?. Replace('a', 'z'); // not allowed
        }
    }
}
