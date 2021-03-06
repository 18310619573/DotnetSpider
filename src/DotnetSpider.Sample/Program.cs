﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Confluent.Kafka;
using DotnetSpider.Core;
using DotnetSpider.Data.Parser;
using DotnetSpider.Data.Storage;
using DotnetSpider.Downloader;
using DotnetSpider.Kafka;
using DotnetSpider.Sample.samples;


namespace DotnetSpider.Sample
{
	class Program
	{
		static async Task Main(string[] args)
		{
			// await BaseUsage.Run();
			Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
			try
			{
				Func<string, Task> a = async (x) =>
				{
					await Write(x);
					throw new Exception("asdfasdf");
				};
				await a("aaaa");
			}
			catch (Exception e)
			{
			}

			// await DistributedSpider.Run(); 
			Console.Read();
		}

		static Task Write(string msg)
		{
			Console.WriteLine(msg);
			return Task.CompletedTask;
		}
	}
}