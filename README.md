# NinjaTrader8_UnitTests
Experiment to devise a means to unit test NinjaScript (https://ninjatrader.com/support/helpGuides/nt8/en-us/ninjascript.htm)

NinjaTrader (https://ninjatrader.com/Build) is an excellent platform for coding algorithmic strategies.

However, frustratingly, NinjaScript cannot be coded according to Test Driven Development methodologies. 

To unit test NinjaScript with say MSTest, knowledge of how to instantiate a Strategy or Indicator object is required.

This information is hidden in the NinjaTrader proprietary codebase, and is unavailable to the public.

This repository is an attempt to experiment with an approach to "unit testing" NinjaScript.

The idea herein is to run the NinjaScript code regularly on a chart (with just one bar!) while under development, so that the OnBarUpdate method can be used to call the test code. Please see the attached and ping me if it is not obvious what I am trying to do...

At present, the approach can handle testing certain code patterns, but not others. For example, it cannot yet handle testing code that uses say objects like indicators that should be mocked. 

Anyone have any ideas how to deal with this? All contributions welcome!

Thanks!

Ben
