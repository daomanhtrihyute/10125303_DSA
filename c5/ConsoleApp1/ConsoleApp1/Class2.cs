using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BrowserHistory
    {
        private Stack<string> backStack = new Stack<string>();
        private Stack<string> forwardStack = new Stack<string>();
        private string currentPage = "";

        public void Visit(string url)
        {
            if (!string.IsNullOrEmpty(currentPage))
            {
                backStack.Push(currentPage);
            }
            currentPage = url;
            forwardStack.Clear();
            Console.WriteLine($"TRUY CẬP TRANG: {currentPage}");
        }

        public void Back()
        {
            if (backStack.Count > 0)
            {
                forwardStack.Push(currentPage);
                currentPage = backStack.Pop();
                Console.WriteLine($"QUAY LẠI TRANG: {currentPage}");
            }
            else
            {
                Console.WriteLine("KHÔNG THỂ QUAY LẠI.");
            }
        }

        public void Forward()
        {
            if (forwardStack.Count > 0)
            {
                backStack.Push(currentPage);
                currentPage = forwardStack.Pop();
                Console.WriteLine($"CHUYỂN TIẾP TỚI TRANG: {currentPage}");
            }
            else
            {
                Console.WriteLine("KHÔNG THỂ CHUYỂN TIẾP.");
            }
        }
    }

    class Bai2_C5
    {
        public static void Run()
        {
            BrowserHistory browser = new BrowserHistory();
            browser.Visit("google.com");
            browser.Visit("github.com");
            browser.Back();
            browser.Forward();
        }
    }
}
