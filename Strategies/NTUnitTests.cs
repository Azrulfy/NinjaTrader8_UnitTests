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
	public partial class Strategy
	{
		#region Variables
		private int tests = 0;
		private int passes = 0;
		#endregion
		
		/// <summary>
		/// Tracks test count and passes
		/// </summary>
		/// <param name="result"></param>
		protected void assertResult(bool result,
									[System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
		{
			if (result)
			{
				passes += 1;
			}
			
			else
			{
				this.logError(memberName);		
			}
			
			tests += 1;			
		}
		
		/// <summary>
		/// Writes name of failed test to NT log
		/// </summary>
		/// <param name="memberName"></param>
		private void logError(string memberName)
		{
			Log(string.Format("Test failed of:\t'{0}'", memberName), LogLevel.Information);
		}
		
		/// <summary>
		/// Writes test summary to NT log
		/// </summary>
		protected void logSummary()
		{
			Log(string.Format("Unit tests:\t{0}\tpasses:\t\t{1}\tfailures:\t\t{2}",
								this.tests,
								this.passes,
								this.tests - this.passes),
				LogLevel.Information);			
		}
		
		/// <summary>
		/// Runs the test of any method taking two integer
		/// arguments and returning an integer
		/// (as far as I can see, a similar method to this  
		/// would be needed for each method signature to be
		/// tested in order to handle runtime exceptions 
		/// without stopping all tests.... :(...)
		/// </summary>
		/// <param name="method"></param>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		protected int testIntIntInt(Func<int, int, int> method, int a, int b)
		{
			int  result = int.MaxValue;

			try
			{
				result = method(a,b);	
			}
			
			catch(Exception ex)
			{
				Log(ex.ToString(), LogLevel.Information);
			}
			
			return result;
		}

		#region Properties
		[NinjaScriptProperty]
		[Display(ResourceType = typeof(Custom.Resource), Name = "Run Unit Tests", GroupName = "Unit Tests", Order = 1)]
		public bool RunUnitTests
		{ get; set; }
		#endregion
	}
}