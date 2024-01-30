using System;
namespace TimerPro.Custom
{
	public class TimerLogic
	{
		private int _intSec;
		private int _intMin;
		private int _intHours;

		public TimerLogic()
		{
			Reset();
		}

		public void Reset()
		{
			_intSec = 0;
			_intMin = 0;
			_intHours = 0;
		}

		public void SetTickCount()
		{
			_intSec++;

			if(_intSec == 60)
			{
				_intSec = 0;
				_intMin++;

				if(_intMin == 60)
				{
					_intMin = 0;
					_intHours++;
				}
			}
		}

		public string GetFormattedString()
		{
			return _intHours.ToString().PadLeft(2,'0') + ":" + _intMin.ToString().PadLeft(2,'0') + ":" + _intSec.ToString().PadLeft(2,'0');
		}

	}
}

