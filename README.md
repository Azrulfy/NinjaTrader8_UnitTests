# NinjaTrader8_UnitTests
## Experiment to devise a means to unit test NinjaScript 
(For more info on NinjaScript, please see https://ninjatrader.com/support/helpGuides/nt8/en-us/ninjascript.htm)

NinjaTrader (https://ninjatrader.com/Build) is an excellent platform for coding algorithmic strategies.

However, at present NinjaScript cannot be coded according to Test Driven Development methodologies ( https://en.wikipedia.org/wiki/Test-driven_development ). To unit test NinjaScript with say MSTest, knowledge of how to instantiate a Strategy or Indicator object is required. This information is hidden in the NinjaTrader proprietary codebase, and is unavailable to the public.

This repository is an attempt to experiment with an approach to "unit testing" NinjaScript so that better quality NinjaScript code can be written (i.e. better quality here means better test coverage, easier to re-factor, easier to regression test, etc.). The idea is to run the NinjaScript code under development regularly on a chart with at least one bar so that the OnBarUpdate method can be used to call and run "test code". Please see the attached code samples and ping me if it is not obvious what I am trying to do...

At present, the approach can handle the testing of certain code patterns, but not of others. For example, I believe it cannot handle testing code that uses objects like say indicators that should be mocked in order to ensure repeatable unit testing. Mocking of indicators 
would require knowledge of how to instantiate an indicator object, proprietary knowledge not available to the public.

For example, see the **methodWithIndicators** method in the attached MyCustomStrategy.cs:

```		/// <summary>
		/// Returns true or false depending on a condition based on indicators
		/// </summary>
		/// <param name="fast"></param>
		/// <returns></returns>
		private bool methodWithIndicators(SMA fast, SMA slow)
		{
			if (fast[0] - slow[0] > 2)
			{
				return true;
			}
			return false;
		}
```

To test this method, it should be possible to overload the method with a a specific SMA fast and SMA slow ensuring that the method should return true, and to test that it does so. And similarly, it should be possible also to overload with a spcific SMA fast and SMA slow that ensure the method returns false, and to test that it does so (please see the two commented out tests **methodWithIndicatorsReturnsTrue()** and **methodWithIndicatorsReturnsFalse()** in the file MyCustomSTrategyUnitTest.cs). Typically in unit testing, objects like __SMA fast__ and __SMA slow__ would be constructed using mocking tools to ensure they exhibited whatever behaviour was required for the test. At present, I don't believe there is a means to do this with NinjaScript indicators.

Anyone have any ideas how to deal with this? All contributions welcome!

Thanks!

Ben

NB - please see also the following forum post: https://ninjatrader.com/support/forum/forum/ninjatrader-8/add-on-development/1035646-unit-testing
