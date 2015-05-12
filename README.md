# Selkie.Common

The package contains common classes and interfaces to replace some .Net classes: IRandom, IDateTime, ITimer, ITimerFactory, IDisposer and ISelkieConsole.
 
# Examples:
SelkieConsole
```CS
public SelkieConsoleExample()
{
	var console = new SelkieConsole();

	console.WriteLine("Hello World!");
	console.WriteLine("Hello {0} {1}",
					  "World!",
					  "(second time)");
}
```

SelkieDateTime
```CS
public SelkieDateTimeExample()
{
	var dateTime = new SelkieDateTime();

	Console.WriteLine("DateTime.Now = {0}",
					  dateTime.Now);
}
```

SelkieRandomExample
```CS
public SelkieRandomExample()
{
	var random = new SelkieRandom();

	for ( int i = 0 ; i < 10 ; i++ )
	{
		var number = random.Next(1,
								 10);

		Console.WriteLine("Random numer {0}...",
						  number);
	}
}`
```

SelkieRandomExample
```CS
public sealed class SelkieTimerExample : IDisposable
{
	private readonly SelkieTimer m_Timer;
	private readonly int m_DueTimeInMs = 5000;
	private readonly int m_PeriodTimeInMs = 2000;

	private int m_Counter;

	public SelkieTimerExample()
	{
		m_Timer = new SelkieTimer();

		m_Timer.Initialize(OnTimmer,
						   m_DueTimeInMs,
						   m_PeriodTimeInMs);
	}

	public void Dispose()
	{
		m_Timer.Dispose();
	}

	private void OnTimmer(object state)
	{
		m_Counter++;

		Console.WriteLine("OnTimer called {0} x times...",
						  m_Counter);
	}
}
```

# Selkie
Selkie.Common is part of the Selkie project which is based on Castle Windsor and EasyNetQ. The main goal of the Selkie project is to calculate and displays the shortest path for a boat travelling along survey lines from point A to B. The algorithm takes into account the minimum required turn circle of a vessel required to navigate from one line to another.

The project started as a little ant colony optimization application. Over time the application grew and was split up into different services which communicate via RabbitMQ. The whole project is used to try out TDD, BDD, DRY and SOLID.

### Selkie Projects

* [Selkie](https://github.com/tschroedter/Selkie)
* Selkie ACO
* [Selkie Common](https://github.com/tschroedter/Selkie.Common)
* [Selkie EasyNetQ](https://github.com/tschroedter/Selkie.EasyNetQ)
* [Selkie Geometry] (https://github.com/tschroedter/Selkie.Geometry)
* [Selkie NUnit Extensions](https://github.com/tschroedter/Selkie.NUnit.Extensions)
* Selkie Racetrack
* Selkie Services ACO
* [Selkie Services Common](https://github.com/tschroedter/Selkie.Services.Common)
* Selkie Services Lines
* Selkie Services Monitor
* Selkie Services Racetracks
* Selkie Web
* [Selkie Windsor](https://github.com/tschroedter/Selkie.Windsor)
* Selkie WPF
* [Selkie XUnit Extensions](https://github.com/tschroedter/Selkie.XUnit.Extensions)

