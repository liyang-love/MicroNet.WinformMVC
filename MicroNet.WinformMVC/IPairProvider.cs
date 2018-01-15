using System.Collections.Generic;

namespace    MicroNet.WinformMVC
{
    public interface IPairProvider
    {
        IPairRule PairRule { get; }
        IEnumerable<ViewControllerPair> ViewControllerPairs { get; }
        bool TryGetViewControllerPair(string pairName, out ViewControllerPair viewControllerPair);
    }
}