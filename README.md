# NinjaTrader8_UnitTests
## Experiment to devise a means to unit test NinjaScript 
(For more infor on NinjaScript, please see https://ninjatrader.com/support/helpGuides/nt8/en-us/ninjascript.htm)

NinjaTrader (https://ninjatrader.com/Build) is an excellent platform for coding algorithmic strategies.

However, at present NinjaScript cannot be coded according to Test Driven Development methodologie ( https://en.wikipedia.org/wiki/Test-driven_development ). To unit test NinjaScript with say MSTest, knowledge of how to instantiate a Strategy or Indicator object woukld be required. This information is hidden in the NinjaTrader proprietary codebase, and is unavailable to the public.

This repository is an attempt to experiment with an approach to "unit testing" NinjaScript so that better quality NinjaScript code can be written (i.e. better quality here means better test coverage, easier to re-factor, easier to regression test, etc.). The idea is to run the NinjaScript code under development regularly on a chart with at least one bar so that the OnBarUpdate method can be used to call and run "test code". Please see the attached code samples and ping me if it is not obvious what I am trying to do...

At present, the approach can handle the testing of certain code patterns, but not of others. For example, I believe it cannot handle testing code that uses objects like say indicators or strategies that would need to be mocked for unit testing.

Anyone have any ideas how to deal with this? All contributions welcome!

Thanks!

Ben

NB - please see also the following forum post: https://ninjatrader.com/support/forum/forum/ninjatrader-8/add-on-development/1035646-unit-testing
