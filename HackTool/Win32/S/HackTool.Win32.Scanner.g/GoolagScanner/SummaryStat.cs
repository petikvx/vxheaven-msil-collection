using System;

namespace GoolagScanner;

public class SummaryStat
{
	private int _scansSuccess;

	private int _scansFailed;

	private int _scansNoResult;

	private DateTime _starttime;

	private DateTime _endtime;

	public int Count => _scansFailed + _scansNoResult + _scansSuccess;

	public int ScansSuccess
	{
		get
		{
			return _scansSuccess;
		}
		set
		{
			_scansSuccess = value;
		}
	}

	public int ScansFailed
	{
		get
		{
			return _scansFailed;
		}
		set
		{
			_scansFailed = value;
		}
	}

	public int ScansNoResult
	{
		get
		{
			return _scansNoResult;
		}
		set
		{
			_scansNoResult = value;
		}
	}

	public DateTime StartTime => _starttime;

	public DateTime EndTime => _endtime;

	public SummaryStat()
	{
		_scansSuccess = 0;
		_scansFailed = 0;
		_scansNoResult = 0;
	}

	public SummaryStat(int scansSuccess, int scansFailed, int scansNoResult)
	{
		_scansSuccess = scansSuccess;
		_scansFailed = scansFailed;
		_scansNoResult = scansNoResult;
	}

	public void captureStartTime()
	{
		_starttime = DateTime.Now;
	}

	public void captureEndTime()
	{
		_endtime = DateTime.Now;
	}
}
