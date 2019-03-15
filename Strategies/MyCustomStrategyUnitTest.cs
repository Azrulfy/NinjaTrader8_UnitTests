#region Using declarations
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Serialization;
using NinjaTrader.Cbi;
using NinjaTrader.Gui;
using NinjaTrader.Gui.Chart;
using NinjaTrader.Gui.SuperDom;
using NinjaTrader.Gui.Tools;
using NinjaTrader.Data;
using NinjaTrader.NinjaScript;
using NinjaTrader.Core.FloatingPoint;
using NinjaTrader.NinjaScript.Indicators;
using NinjaTrader.NinjaScript.DrawingTools;
#endregion

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class MyCustomStrategy : Strategy
	{
		/// <summary>
		/// Runs Unit Tests
		/// </summary>
		private void runTests()
		{
			// The unit tests
			intSumReturnsCorrectSum();
			intProductReturnsCorrectProduct();
			
			// methodWithIndicatorsReturnsTrue()
			// methodWithIndicatorsReturnsFalse()
			
			this.logSummary();
		}

		
		
		// Can do ...
		
		/// <summary>
		/// Unit Test
		/// </summary>
		private void intSumReturnsCorrectSum()
		{
			int a = 1;
			int b = 2;
			
			int result = this.testIntIntInt(this.intSum, a, b);

			assertResult(result == a + b);
		}
		
		/// <summary>
		/// Unit Test
		/// </summary>
		private void intProductReturnsCorrectProduct()
		{
			int a = 1;
			int b = 2;
			
			int result = this.testIntIntInt(this.intProduct, a, b);

			assertResult(result == a * b);
		}

		
		
		// Cannot do ...
		
		/// <summary>
		/// Unit Test
		/// </summary>
		private void methodWithIndicatorsReturnsTrue()
		{
			// to test conditions where method returns true
			
			// fastMock = something ...
			// slowMock = something ...
			
			// bool result = this.testIndyIndyBool(this.methodWithIndicarors, fastMock, slowMock);

			// assertResult(result == true);
		}
		
		/// <summary>
		/// Unit Test
		/// </summary>
		private void methodWithIndicatorsReturnsFalse()
		{
			// to test conditions where method returns false

			// fastMock = something ...
			// slowMock = something ...
			
			// bool result = this.testIndyIndyBool(this.methodWithIndicarors, fastMock, slowMock);

			// assertResult(result != true);
		}
	}
}