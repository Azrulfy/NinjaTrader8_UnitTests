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
		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description									= @"Example custom strategy for demonstrating NTUNitTest";
				Name										= "MyCustomStrategy";
			}
		}

		protected override void OnBarUpdate()
		{
			if (this.RunUnitTests)
			{
				this.runTests();
			}
		}

		/// <summary>
		/// Returns integer sum of a + b
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		private int intSum(int a, int b)
		{
			return a + b;
		}
		
		/// <summary>
		/// Returns integer product of a * b
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		private int intProduct(int a, int b)
		{
			throw new NotImplementedException("not implemented");
		}
		
		/// <summary>
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
	}
}
