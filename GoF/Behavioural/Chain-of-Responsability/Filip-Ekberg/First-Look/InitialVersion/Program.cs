using System;
using System.Globalization;
using InitialVersion.Business;
using InitialVersion.Business.Models;

namespace InitialVersion {
    internal static class Program {
        internal static void Main(string[] args) {
            User user = new User(
                "Filip Ekberg",
                "870101XXXX",
                new DateTimeOffset(1987, 01, 29, 00, 00, 00, TimeSpan.FromHours(2)),
                new RegionInfo("SE")
            );

            UserProcessor processor = new UserProcessor();
            bool result = processor.Register(user);
            Console.WriteLine(result);
        }
    }
}
