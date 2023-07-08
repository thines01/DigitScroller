using System.Linq;

namespace DigitScroller
{
   public class CDigitScroller
   {
      private ulong _ulngDigits { get; set; }
      private char _chrPadding { get; set; }

      public CDigitScroller()
      {
         _ulngDigits = 0;
         _chrPadding = '0';
      }

      public CDigitScroller(ulong ulngDigits)
      {
         _ulngDigits = ulngDigits;
         _chrPadding = '0';
      }

      public CDigitScroller(ulong ulngDigits, char chrPadding)
      {
         _ulngDigits = ulngDigits;
         _chrPadding = chrPadding;
      }

      public string Scroll(ushort numPlaces)
      {
         return string.Format("{0}{1}",
            (_ulngDigits++).ToString().PadLeft(numPlaces, _chrPadding),
            new string(Enumerable.Repeat<char>('\b', numPlaces).ToArray()));
      }

      public string Scroll()
      {
         ushort numPlaces = (ushort)_ulngDigits.ToString().Length;

         return string.Format("{0}{1}",
            (_ulngDigits++).ToString().PadLeft(numPlaces, _chrPadding),
            new string(Enumerable.Repeat<char>('\b', numPlaces).ToArray()));
      }
   }
}
